using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xlgen
{
    public static class GenInternal
    {

        public static Dictionary<Type, MethodInfo[]> FilterTypes(Dictionary<Type, MethodInfo[]> types)
        {
            var res = new Dictionary<Type, MethodInfo[]>();
            foreach (var kv in types)
            {
                var methods = kv.Value.Where(m => m.ReturnType != typeof(void) && !m.IsGenericMethod).ToArray();
                if (methods.Length > 0)
                    res[kv.Key] = methods;
            }
            return res;
        }

        public static MemberDeclarationSyntax Generate(Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            var typeString = NameHelper.GetNameClean(t);
            var internalMethodName = NameHelper.GetInternalFunName(t, m, alternateNames);

            #region Build Function Call
            ExpressionSyntax functionCall;
            if (m.Name.StartsWith("get_"))
            {
                functionCall = SyntaxFactory.MemberAccessExpression(
                         SyntaxKind.SimpleMemberAccessExpression,
                         NameHelper.GetNameClean(t).AsIdentifier(),
                         name: m.Name.Substring(4).AsIdentifier());
            }
            else if (m.Name == "op_Explicit")
            {
                var arg = m.GetParameters().First().Name;
                functionCall = SyntaxFactory.ParseExpression("(" + m.ReturnType.ToString() + ")"+ arg);
            }
            else if (m.Name == "op_Implicit")
            {
                var arg = m.GetParameters().First().Name;
                functionCall = SyntaxFactory.ParseExpression(arg);
            }
            else if (m.Name == "op_Addition")
            {
                var p = m.GetParameters();
                functionCall = SyntaxFactory.ParseExpression(p[0].Name + " + " + p[1].Name);
            }
            else if (m.Name == "op_Subtraction")
            {
                var p = m.GetParameters();
                functionCall = SyntaxFactory.ParseExpression(p[0].Name + " - " + p[1].Name);
            }
            else if (m.Name == "op_Multiply")
            {
                var p = m.GetParameters();
                functionCall = SyntaxFactory.ParseExpression(p[0].Name + " * " + p[1].Name);
            }
            else if (m.Name == "op_Division")
            {
                var p = m.GetParameters();
                functionCall = SyntaxFactory.ParseExpression(p[0].Name + " / " + p[1].Name);
            }
            else if (m.Name == "op_Modulus")
            {
                var p = m.GetParameters();
                functionCall = SyntaxFactory.ParseExpression(p[0].Name + " % " + p[1].Name);
            }
            else if (m.Name == "op_Equality")
            {
                var p = m.GetParameters();
                functionCall = SyntaxFactory.ParseExpression(p[0].Name + " == " + p[1].Name);
            }
            else if (m.Name == "op_Inequality")
            {
                var p = m.GetParameters();
                functionCall = SyntaxFactory.ParseExpression(p[0].Name + " != " + p[1].Name);
            }
            else if (m.Name == "op_UnaryPlus")
            {
                var p = m.GetParameters();
                functionCall = SyntaxFactory.ParseExpression("+" + p[0].Name);
            }
            else if (m.Name == "op_UnaryNegation")
            {
                var p = m.GetParameters();
                functionCall = SyntaxFactory.ParseExpression("-" + p[0].Name);
            }
            else
            {
                var functionAccess = SyntaxFactory.MemberAccessExpression(
                          SyntaxKind.SimpleMemberAccessExpression,
                          typeString.AsIdentifier(),
                          name: m.Name.AsIdentifier());

                var arguments = GetArguments(m);
                functionCall = SyntaxFactory.InvocationExpression(functionAccess, arguments);
            }
            #endregion


            var returnStatement = SyntaxFactory.Block(SyntaxFactory.ReturnStatement(functionCall));

            var parametersList = GetParameters(m);

            var inlineAtt = SyntaxFactory.Attribute("MethodImpl".AsIdentifier())
                                .AddArgumentListArguments(SyntaxFactory.AttributeArgument(
                                    SyntaxFactory.ParseExpression("MethodImplOptions.AggressiveInlining")));

            var method = SyntaxFactory.MethodDeclaration(
                NameHelper.GetNameClean(m.ReturnType).AsTypeSyntax(), internalMethodName)
                .AddModifiers(
                    SyntaxFactory.Token(SyntaxKind.InternalKeyword),
                    SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .WithParameterList(parametersList)
                .WithBody(returnStatement)
                .AddAttributeLists(SyntaxFactory.AttributeList().AddAttributes(inlineAtt));

            return method;
        }


        public static SyntaxNode Namespace(string name, MemberDeclarationSyntax m)
        {
            return SyntaxFactory.NamespaceDeclaration(name.AsIdentifier())
                .AddUsings("System".AsUsing())
                .AddUsings("System.Runtime.CompilerServices".AsUsing())
                .AddMembers(m);
        }

        private static ParameterListSyntax GetParameters(MethodInfo m)
        {
            var parameters = m.GetParameters();
            var parametersSyntax = parameters.Select(p =>
                SyntaxFactory.Parameter(SyntaxFactory.Identifier(p.Name))
                    .WithType(NameHelper.GetNameClean(p).AsTypeSyntax()));

            var sepSyntaxList = new SeparatedSyntaxList<ParameterSyntax>();
            sepSyntaxList = sepSyntaxList.AddRange(parametersSyntax);

            return SyntaxFactory.ParameterList(sepSyntaxList);
        }

        private static ArgumentListSyntax GetArguments(MethodInfo m)
        {
            var parameters = m.GetParameters();
            var pList = parameters.ConvertAll(p => NameHelper.GetArgNameClean(p).AsArgument());
            return SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(pList));
        }
    }
}
