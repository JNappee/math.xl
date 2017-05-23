using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace math.net.xlgen
{
    public static class GenExcelExports
    {
        public static Dictionary<Type, MethodInfo[]> FilterTypes(Dictionary<Type, MethodInfo[]> types)
        {
            var res = new Dictionary<Type, MethodInfo[]>();
            foreach (var kv in types)
            {
                var methods = kv.Value.Where(IsAcceptedMethod).ToArray();
                if (methods.Length > 0)
                    res[kv.Key] = methods;
            }
            return res;
        }
        public static MemberDeclarationSyntax Generate(string internalClassName, Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            var internalMethodName = NameHelper.GetInternalFunName(t, m, alternateNames);
            var externalMethodName = NameHelper.GetExternalFunName(t, m, alternateNames);
            var excelExportName = NameHelper.GetExcelFunName(t, m, alternateNames);
            var doc = Doc.GetOrNull(t, m);


            var functionAccess = SyntaxFactory.MemberAccessExpression(
                      SyntaxKind.SimpleMemberAccessExpression,
                     internalClassName.AsIdentifier(),
                      name: internalMethodName.AsIdentifier());

            var arguments = GetArguments(m);
            var functionCall = SyntaxFactory.InvocationExpression(functionAccess, arguments);

            var returnStatement = SyntaxFactory.ReturnStatement(functionCall);

            var catchClause = SyntaxFactory.CatchClause()
                            .WithDeclaration(SyntaxFactory.CatchDeclaration("Exception".AsTypeSyntax(),
                                SyntaxFactory.Identifier("ex")))
                            .AddBlockStatements(SyntaxFactory.ReturnStatement(
                                SyntaxFactory.InvocationExpression(SyntaxFactory.ParseExpression("Error.ExcelHandle"),
                                SyntaxFactory.ArgumentList(
                                        SyntaxFactory.SeparatedList(new[] { SyntaxFactory.Argument("ex".AsIdentifier()) })))));

            var trycatch = SyntaxFactory.TryStatement()
                .AddBlockStatements(returnStatement)
                .AddCatches(catchClause);

            DocFunction docF = null;
            var parametersList = GetParameters(m, docF);


            string ExcelFuncAtt = "Name=\"" + excelExportName + "\"";
            if (doc != null)
                ExcelFuncAtt += ", Description=@\"" + doc.Summary + "\"";
            var attFunction = SyntaxFactory.AttributeArgument(SyntaxFactory.ParseExpression(ExcelFuncAtt));

            var functionExcelAtt = SyntaxFactory.Attribute("ExcelFunction".AsIdentifier())
                                .AddArgumentListArguments(attFunction);


            var method = SyntaxFactory.MethodDeclaration("object".AsTypeSyntax(), externalMethodName)
                .AddModifiers(
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                    SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .WithParameterList(parametersList)
                .WithBody(SyntaxFactory.Block(trycatch))
                .AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(functionExcelAtt));

            return method;
        }

        public static ClassDeclarationSyntax Class(string name, IEnumerable<MemberDeclarationSyntax> m)
        {
            return SyntaxFactory.ClassDeclaration(name)
                .WithMembers(SyntaxFactory.List(m))
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                SyntaxFactory.Token(SyntaxKind.StaticKeyword));
        }

        public static SyntaxNode Namespace(string name, MemberDeclarationSyntax m)
        {
            return SyntaxFactory.NamespaceDeclaration(name.AsIdentifier())
                .AddUsings("System".AsUsing())
                .AddUsings("System.Collections.Generic".AsUsing())
                .AddUsings("ExcelDna.Integration".AsUsing())
                .AddMembers(m);
        }

        private static ParameterListSyntax GetParameters(MethodInfo m, DocFunction docF)
        {
            var parameters = m.GetParameters();
            var parametersSyntax = parameters.Select(p =>
            {
                var pa = SyntaxFactory.Parameter(SyntaxFactory.Identifier(p.Name))
                        .WithType(NameHelper.GetNameClean(p).AsTypeSyntax());
                // add doc
                {

                    string ExcelFuncAtt = "Name=\"" + p.Name + "\"";
                    if (docF != null)
                    {
                        var ps = docF.Params.FirstOrDefault(a => a.Name == p.Name);
                        if (ps != null)
                            ExcelFuncAtt += ", Description=@\"" + ps.Summary + "\"";
                    }
                    var attFunction = SyntaxFactory.AttributeArgument(SyntaxFactory.ParseExpression(ExcelFuncAtt));

                    var paramExcelAtt = SyntaxFactory.Attribute("ExcelArgument".AsIdentifier())
                                        .AddArgumentListArguments(attFunction);

                    pa = pa.AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(paramExcelAtt));
                }
                return pa;

            });

            var sepSyntaxList = new SeparatedSyntaxList<ParameterSyntax>();
            sepSyntaxList = sepSyntaxList.AddRange(parametersSyntax);

            return SyntaxFactory.ParameterList(sepSyntaxList);
        }

        private static ArgumentListSyntax GetArguments(MethodInfo m)
        {
            var parameters = m.GetParameters();
            var pList = parameters.Select(p => NameHelper.GetArgNameClean(p).AsArgument());
            return SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(pList));
        }

        static bool IsAcceptedMethod(MethodInfo m)
        {
            return !(m.IsGenericMethod
                || !IsAcceptedOutputType(m)
                || !AreInputTypesAccepted(m)
                || m.GetCustomAttributes().OfType<ObsoleteAttribute>().Count() > 0);
        }

        private static Type[] AcceptedTypes = new Type[]
            {
                 typeof(Int32)                    ,
                 typeof(Int32[])                  ,
                 typeof(IEnumerable<Int32>)       ,
                 typeof(Int64)                    ,
                 typeof(Int64[])                  ,
                 typeof(IEnumerable<Int64>)       ,
                 typeof(double)                   ,
                 typeof(double[])                 ,
                 typeof(double[][])               ,
                 typeof(double[,])                ,
                 typeof(IEnumerable<double>)      ,
                 typeof(Complex)                  ,
                 typeof(Complex[])                ,
                 typeof(IEnumerable<Complex>)     ,
                 typeof(bool)                     ,
                 typeof(bool[])                   ,
                 typeof(IEnumerable<bool>)
            };

        static bool IsAcceptedOutputType(MethodInfo m)
        {
            return AcceptedTypes.Contains(m.ReturnType);
        }

        static bool AreInputTypesAccepted(MethodInfo m)
        {
            foreach (var p in m.GetParameters())
                if (!AcceptedTypes.Contains(p.ParameterType))
                    return false;
            return true;
        }
    }
}
