using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace math.net.xlgen
{
    internal static class NameHelper
    {
        public static string GetArgNameClean(ParameterInfo pi)
        {
            var name = pi.Name;

            if (pi.ParameterType.IsByRef)
                name = (pi.IsOut ? " out " : " ref ") + name;
            return name;
        }

        public static string GetNameClean(ParameterInfo pi)
        {
            var typeName = GetNameClean(pi.ParameterType);

            if (pi.ParameterType.IsByRef)
            {
                typeName = (pi.IsOut ? " out " : " ref ") + typeName;
                typeName = typeName.Replace("&", " ");
            }
            return typeName;
        }
        public static string GetNameClean(Type type)
        {
            // Fixes issues with System.Void
            if (type == typeof(void))
                return "void";

            var name = type.Namespace + "." + type.Name;
            if (type.IsGenericType)
            {
                if (type.GenericTypeArguments.Length == 0)
                {
                    name = name.Replace("`1", "<System.Double>");
                }
                else
                {
                    name = name.Replace("`1", "").Replace("`2", "").Replace("`3", "").Replace("`4", "");
                    name = name + "<" + string.Join(",", type.GetGenericArguments().ConvertAll(GetNameClean)) + ">";
                }
                return name;
            }
            else if (type.IsArray)
            {
                var rank = type.GetArrayRank();
                string commas = "";
                for (int i = 0; i < rank - 1; i++)
                    commas += ",";
                return GetNameClean(type.GetElementType()) + "[" + commas + "]";
            }
            else if (type.Name == "T")
                return "System.Double";
            else
                return name;

        }

        public static string GetExcelFunName(Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            var typeString = GetNameClean(t);
            var mName = m.Name;
            if (alternateNames.ContainsKey(m))
                mName = alternateNames[m];
            return typeString.Replace("MathNet.Numerics.", "MN.") + "." + mName.Replace("get_", "");
        }

        internal static string GetInternalFunName(Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            return GetFunName(t, m, alternateNames, "_Internal");
        }

        internal static string GetExternalFunName(Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            return GetFunName(t, m, alternateNames, "");
        }

        internal static string GetDocName(Type t, MethodInfo m)
        {
            var typeString = t.Namespace + "." + t.Name;
            var fullMethodName = m.ToString();
            // Remove output type
            var afterReturnTypeIndex = fullMethodName.IndexOf(m.Name);
            var methodName = fullMethodName.Substring(afterReturnTypeIndex);
            return (typeString + "." + methodName).Replace(" ", "");
        }


        private static Regex genericRE = new Regex(@"(.*)\<.*\>(.*)");
        private static string GetFunName(Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames, string postFix)
        {
            var typeString = GetNameClean(t);
            var mName = m.Name;
            if (alternateNames.ContainsKey(m))
                mName = alternateNames[m];
            var res = typeString.Replace("MathNet.Numerics.", "")
                .Replace(".", "_").Replace("`1", "") + "_" + mName.Replace("get_", "") + postFix;
            var match = genericRE.Match(res);
            if (match.Success)
            {
                return match.Groups[1].Value + match.Groups[2].Value;
            }
            else
                return res;
        }
    }
}
