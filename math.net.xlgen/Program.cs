using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.IO;
using System.Reflection;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace math.net.xlgen
{
    class Program
    {
        private static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            try
            {
                var methods = GetMathNetMethods();

                var alternateNames = new Dictionary<MethodInfo, string>();
                // find all methods with same name and number or args 
                var filtered = methods.ToDictionary(kv => kv.Key, 
                    kv => kv.Value.GroupBy(v => v.Name).SelectMany(
                        g => FilterGroups(g, ref alternateNames)).ToArray());

              //  GenInternals(filtered, alternateNames);
                GenExcelExport(filtered, alternateNames);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Returns all methods in Math.Net that dont return void and arent Generic
        /// </summary>
        /// <returns></returns>
        public static Dictionary<Type, MethodInfo[]> GetMathNetMethods()
        {
            var MNAssembly = typeof(MathNet.Numerics.Combinatorics).Assembly;
            var types = MNAssembly.GetTypes();
            var res = new Dictionary<Type, MethodInfo[]>();
            foreach (var t in types.Where(type => type.IsPublic))
            {
                var ms = t.GetMethods();
                ms = ms.Where(IsAcceptedMethod).ToArray();
                if (ms.Length > 0)
                    res[t] = ms;
            }
            return res;
        }

        public static bool IsAcceptedMethod(MethodInfo m)
        {
            return m.IsPublic
                && !m.IsGenericMethod
                && m.ReturnType != typeof(void)
                && m.ReturnType != typeof(MathNet.Numerics.Complex32)
                && m.ReturnType != typeof(Type)
                && m.ReturnType != typeof(Int64)
                && m.Name != "GetHashCode"
                && m.Name != "ToString"
                && m.Name != "Equals"
                && m.Name != "get_HResult"
                && m.Name != "BeginInvoke"
                && m.Name != "EndInvoke"
                && m.GetParameters().All(p => 
                    p.ParameterType != typeof(MathNet.Numerics.Complex32)
                    && p.ParameterType != typeof(Single)
                    && p.ParameterType != typeof(Int64)
                    && !p.ParameterType.IsByRef
                    )
                && (Conf.AllowObsolete || m.GetCustomAttributes().OfType<ObsoleteAttribute>().Count() == 0);
        }



        static List<MethodInfo> FilterGroups(IGrouping<string, MethodInfo> groups, ref Dictionary<MethodInfo, string> alternateNames)
        {
            if (groups.Count() == 0)
                return new List<MethodInfo>();
            if (groups.Count() == 1)
                return new List<MethodInfo>() { groups.First() };
            //choose between one of the overloads
            var orderByNP = groups.GroupBy(m => m.GetParameters().Count()).ToDictionary(g => g.Key, g => g.ToArray());

            var cleanedDict = new Dictionary<int, MethodInfo>();
            // first choose any function with same nb of parameters.
            var duplicates = orderByNP.Where(kv => kv.Value.Length > 0);
            foreach (var d in orderByNP)
            {
                if (d.Value.Length > 1)
                {
                    var listOfParams = d.Value.ConvertAll(m => m.GetParameters());
                    for (int i = 0; i < d.Key; i++)
                    {
                        var thisIndexParams = listOfParams.ConvertAll(a => a[i].ParameterType);
                        // if only one is double then that one wins, otherwise the int64

                    }

                    MethodInfo chosen = d.Value.First();
                    cleanedDict[d.Key] = chosen;
                }
                else
                    cleanedDict[d.Key] = d.Value.First();
            }

            if (cleanedDict.Count == 1)
                return new List<MethodInfo>() { cleanedDict.First().Value };


            // Then if all have different number or parameters, change names to name_1, name_2 etc
            foreach (var g in cleanedDict)
                alternateNames[g.Value] = g.Value.Name + "_" + g.Key;

            return cleanedDict.Values.ToList();
        }

        static void GenExcelExport(Dictionary<Type, MethodInfo[]> methods, Dictionary<MethodInfo, string> alternateNames)
        {
            var methodsCode = methods.SelectMany(kv =>
                         kv.Value.Select(m => GenExcelExports.Generate(Conf.Internal_Namespace + "." + Conf.Internal_ClassName,  kv.Key, m, alternateNames)));

            var classCode = Class(Conf.ExcelExport_ClassName, methodsCode);
            Console.WriteLine("Generated " + methodsCode.Count() + " Excel exports.");
            var namespaceCode = GenExcelExports.Namespace(Conf.ExcelExport_Namespace, classCode);


            var cw = new AdhocWorkspace();
            cw.Options.WithChangedOption(CSharpFormattingOptions.IndentBraces, true);
            var code = Formatter.Format(namespaceCode, cw);

            File.WriteAllText(Conf.ExcelExport_WritePath, code.ToString());
        }

        static void GenInternals(Dictionary<Type, MethodInfo[]> methods, Dictionary<MethodInfo, string> alternateNames)
        {
            var methodsCode = methods.SelectMany(kv =>
             kv.Value.Where(m => !m.IsGenericMethod).Select(m => GenInternal.Generate(kv.Key, m, alternateNames)));

            var classCode = Class(Conf.Internal_ClassName, methodsCode);
                Console.WriteLine("Generated " + methodsCode.Count() + " Internal functions.");

            var namespaceCode = GenInternal.Namespace(Conf.Internal_Namespace, classCode);

            var cw = new AdhocWorkspace();
            cw.Options.WithChangedOption(CSharpFormattingOptions.IndentBraces, true);
            var code = Formatter.Format(namespaceCode, cw);

            File.WriteAllText(Conf.Internal_WritePath, code.ToString());
        }

        public static ClassDeclarationSyntax Class(string name, IEnumerable<MemberDeclarationSyntax> m)
        {
            return SyntaxFactory.ClassDeclaration(name)
                .WithMembers(SyntaxFactory.List(m))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                SyntaxFactory.Token(SyntaxKind.StaticKeyword));
        }

    }
}
