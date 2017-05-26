using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace math.net.xlgen
{
    internal static class InternalNameHelper
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
                    return name.Replace("`1", "<System.Double>");

                name = name.Replace("`1", "").Replace("`2", "").Replace("`3", "").Replace("`4", "");
                return name + "<" + string.Join(",", type.GetGenericArguments().ConvertAll(GetNameClean)) + ">";
            }

            if (type.IsArray)
            {
                var rank = type.GetArrayRank();
                string commas = "";
                for (int i = 0; i < rank - 1; i++)
                    commas += ",";
                return GetNameClean(type.GetElementType()) + "[" + commas + "]";
            }

            if (type.Name == "T")
                return "System.Double";

            return name;

        }

        internal static string GetInternalFunName(Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            return GetFunName(t, m, alternateNames, "_Internal");
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
