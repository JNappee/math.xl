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
        private const string excelName = "_Name";
        private const string excelStringName = "_objString";
        private const string referenceName = "_obj";
        public static MemberDeclarationSyntax Generate(string internalClassName, Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            var doc = Doc.GetOrNull(t, m);


            var functionCall = GetFunInvocation(internalClassName, t, m, alternateNames);
            var block = new List<StatementSyntax>();

            // add code to convert excel string into object reference
            if (!m.IsStatic && !m.IsConstructor)
            {
                //var deal = Graph.Instance.Get<PortfolioDealInfo>(Deal);
                var objConv = ("var " + referenceName + " = Graph.Instance.Get<" + InternalNameHelper.GetNameClean(m.DeclaringType) + ">(" + excelStringName + ")").AsExpressionStatement();
                block.Add(objConv);
            }

            // check for objects that have a Mapper
            foreach (var p in m.GetParameters())
            {
                if (TypeHelper.Handles(p.ParameterType))
                {
                    var mapper = TypeHelper.Get(p.ParameterType);
                    if (mapper.NeedsMapping())
                        block.AddRange(mapper.ToExpression(p.Name));
                }
                else
                {
                    var objConv = ("var " + p.Name  + "_obj = Graph.Instance.Get<" 
                        + InternalNameHelper.GetNameClean(p.ParameterType) + ">(" 
                        + p.Name + ")").AsExpressionStatement();
                    block.Add(objConv);
                }
            }

            if (TypeHelper.Handles(m.ReturnType))
            {
                var returnTypeHandler = TypeHelper.Get(m.ReturnType);
                block.AddRange(returnTypeHandler.HandleReturnType(functionCall));
            }
            else
            {
                var objAssign = SyntaxFactory.ExpressionStatement(SyntaxFactory.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                "var res ".AsExpression(), functionCall));
                block.Add(objAssign.WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed));
                var pNames = m.GetParameters().ConvertAll(p => p.Name);
                if (pNames.Length > 0)
                    block.Add(
                        SyntaxFactory.ReturnStatement(("Graph.Instance.Add(res, _Name, " 
                        + string.Join(", ", pNames)+")").AsExpression())
                        .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed));
                else
                    block.Add(
                    SyntaxFactory.ReturnStatement(("Graph.Instance.Add(res, _Name)").AsExpression())
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed));
            }

            var trycatch = ApplyTryCatch(block.ToArray());

            var parametersList = GetParameters(m, doc);
            var functionExcelAtt = BuildMethodAttributes(t, m, alternateNames, doc);


            var externalMethodName = ExcelNameHelper.GetExternalFunName(t, m, alternateNames);
            var method = SyntaxFactory.MethodDeclaration("object".AsTypeSyntax(), externalMethodName)
                .AddModifiers(
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                    SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .WithParameterList(parametersList)
                .WithBody(trycatch)
                .AddAttributeLists(functionExcelAtt);

            return method;
        }

        private static ParameterSyntax OptionsParameter()
        {
            var att = CreateAttribute("ExcelArgument", "Name = \"excel_options\", Description = \"options to format return and manage warnings. ex: fill=string, fill=nan\"");
            return SyntaxFactory.Parameter("excel_options".AsToken())
                    .WithType("string".AsTypeSyntax())
                    .WithDefault(SyntaxFactory.EqualsValueClause("\"None\"".AsExpression()))
                    .AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(att));
        }

        private static AttributeListSyntax BuildMethodAttributes(Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames, DocFunction doc)
        {
            var excelExportName = ExcelNameHelper.GetExcelFunName(t, m, alternateNames)
                .Replace("<System.Double>", "");
            string ExcelFuncAtt = "Name = \"" + excelExportName + "\"";
            if (doc != null)
                ExcelFuncAtt += ", Description = @\"" + doc.Summary + "\"";
            var attFunction = SyntaxFactory.AttributeArgument(SyntaxFactory.ParseExpression(ExcelFuncAtt));

            var functionExcelAtt = SyntaxFactory.Attribute("ExcelFunction".AsIdentifierName())
                                .AddArgumentListArguments(attFunction);
            return SyntaxFactory.AttributeList().AddAttributes(functionExcelAtt);
        }

        private static BlockSyntax ApplyTryCatch(params StatementSyntax[] block)
        {
            var catchClause = SyntaxFactory.CatchClause()
                          .WithDeclaration(SyntaxFactory.CatchDeclaration("Exception".AsTypeSyntax(),
                              SyntaxFactory.Identifier("ex")))
                          .AddBlockStatements(SyntaxFactory.ReturnStatement(
                              SyntaxFactory.InvocationExpression(SyntaxFactory.ParseExpression("Error.ExcelHandle"),
                              SyntaxFactory.ArgumentList(
                                      SyntaxFactory.SeparatedList(new[] { SyntaxFactory.Argument("ex".AsIdentifierName()) })))));

            var trycatch = SyntaxFactory.TryStatement()
                .AddBlockStatements(block)
                .AddCatches(catchClause);
            return SyntaxFactory.Block(trycatch);
        }

        private static InvocationExpressionSyntax GetFunInvocation(string internalClassName, Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            var internalMethodName = InternalNameHelper.GetInternalFunName(t, m, alternateNames);

            var functionAccess = SyntaxFactory.MemberAccessExpression(
                      SyntaxKind.SimpleMemberAccessExpression,
                     internalClassName.AsIdentifierName(),
                      name: internalMethodName.AsIdentifierName());

            var arguments = GetArguments(m);
            return SyntaxFactory.InvocationExpression(functionAccess, arguments);
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
            return SyntaxFactory.NamespaceDeclaration(name.AsIdentifierName())
                .AddUsings("System".AsUsing())
                .AddUsings("System.Collections.Generic".AsUsing())
                .AddUsings("System.Linq".AsUsing())
                .AddUsings("ExcelDna.Integration".AsUsing())
                .AddMembers(m);
        }

        private static ParameterListSyntax GetParameters(MethodInfo m, DocFunction docF)
        {
            var parameters = m.GetParameters();
            var parametersSyntax = parameters.Select(p => p.AsExcelParameter(docF)).ToList();

            if (!m.IsStatic && !m.IsConstructor)
            {
                var pa = excelStringName.AsParameter()
                       .WithType("System.String".AsTypeSyntax());
                var paramExcelAtt = CreateAttribute("ExcelArgument", "Name = \"" + excelStringName
                    + "\", Description = \"Reference object of type [" + m.DeclaringType.ToString() + "]\"");
                pa = pa.AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(paramExcelAtt));
                parametersSyntax.Insert(0, pa);
            }

            if (m.IsConstructor || !TypeHelper.Handles(m.ReturnType))
            {
                var pa = excelName.AsParameter().WithType("System.String".AsTypeSyntax());
                var paramExcelAtt = CreateAttribute("ExcelArgument", "Name = \"" + excelName
                    + "\", Description = \"Name of the result object of type [" + m.ReturnType.ToString() + "]\"");
                pa = pa.AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(paramExcelAtt));
                parametersSyntax.Insert(0, pa);
            }

            var sepSyntaxList = new SeparatedSyntaxList<ParameterSyntax>();
            sepSyntaxList = sepSyntaxList.AddRange(parametersSyntax);

            if (TypeHelper.Handles(m.ReturnType))
            {
                var retHelper = TypeHelper.Get(m.ReturnType);
                if (retHelper.AddOptionsExcelParameter())
                    sepSyntaxList = sepSyntaxList.Add(OptionsParameter());
            }

            return SyntaxFactory.ParameterList(sepSyntaxList);
        }

        internal static AttributeSyntax CreateAttribute(string attributeClass, string attributeContent)
        {
            var attFunction = SyntaxFactory.AttributeArgument(SyntaxFactory.ParseExpression(attributeContent));

            return SyntaxFactory.Attribute(attributeClass.AsIdentifierName())
                                .AddArgumentListArguments(attFunction);
        }

        private static ArgumentListSyntax GetArguments(MethodInfo m)
        {
            var parameters = m.GetParameters();
            var pList = parameters.Select(p => ExcelNameHelper.GetArgNameClean(p).AsArgument()).ToList();
            if (!m.IsStatic && !m.IsConstructor)
                pList.Insert(0, referenceName.AsArgument());
            return SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(pList));
        }


    }
}
