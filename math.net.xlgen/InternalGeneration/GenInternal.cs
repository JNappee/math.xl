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
        private const string referenceName = "_obj";
        public static MemberDeclarationSyntax Generate(Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            if (m.IsStatic)
                return GenerateStatic(t, m, alternateNames);
            return GenerateMethod(t, m, alternateNames);
        }

        private static MemberDeclarationSyntax GenerateMethod(Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            var typeString = InternalNameHelper.GetNameClean(t);
            var internalMethodName = InternalNameHelper.GetInternalFunName(t, m, alternateNames);

            ExpressionSyntax function;

            if (m.Name == "get_Item")
            {
                var args = m.GetParameters().ConvertAll(a => a.Name);
                function = (referenceName + "[" + string.Join(",", args) + "]").AsExpression();
            }
            else if (m.Name.StartsWith("get_"))
                function = (referenceName + "." + m.Name.Substring(4)).AsExpression();
            else
            {
                var functionAccess = SyntaxFactory.MemberAccessExpression(
                     SyntaxKind.SimpleMemberAccessExpression,
                     referenceName.AsIdentifierName(),
                     name: m.Name.AsIdentifierName());

                var arguments = GetArguments(m);
                function = SyntaxFactory.InvocationExpression(functionAccess, arguments);
            }

            var returnStatement = SyntaxFactory.Block(SyntaxFactory.ReturnStatement(function));
            var parametersList = GetParameters(m);
            var method = SyntaxFactory.MethodDeclaration(
                InternalNameHelper.GetNameClean(m.ReturnType).AsTypeSyntax(), internalMethodName)
                .AddModifiers(
                    SyntaxFactory.Token(SyntaxKind.InternalKeyword),
                    SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .WithParameterList(parametersList)
                .WithBody(returnStatement);

            return method;
        }

        private static MemberDeclarationSyntax GenerateStatic(Type t, MethodInfo m, Dictionary<MethodInfo, string> alternateNames)
        {
            var typeString = InternalNameHelper.GetNameClean(t);
            var internalMethodName = InternalNameHelper.GetInternalFunName(t, m, alternateNames);

            #region Build Function Call
            ExpressionSyntax functionCall;
            if (m.Name.StartsWith("get_"))
            {
                functionCall = SyntaxFactory.MemberAccessExpression(
                         SyntaxKind.SimpleMemberAccessExpression,
                         InternalNameHelper.GetNameClean(t).AsIdentifierName(),
                         name: m.Name.Substring(4).AsIdentifierName());
            }
            else if (m.Name == "op_Explicit")
            {
                var arg = m.GetParameters().First().Name;
                functionCall = SyntaxFactory.ParseExpression("(" + m.ReturnType.ToString() + ")" + arg);
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
                          typeString.AsIdentifierName(),
                          name: m.Name.AsIdentifierName());

                var arguments = GetArguments(m);
                functionCall = SyntaxFactory.InvocationExpression(functionAccess, arguments);
            }
            #endregion


            var returnStatement = SyntaxFactory.Block(SyntaxFactory.ReturnStatement(functionCall));

            var parametersList = GetParameters(m);


            var method = SyntaxFactory.MethodDeclaration(
                InternalNameHelper.GetNameClean(m.ReturnType).AsTypeSyntax(), internalMethodName)
                .AddModifiers(
                    SyntaxFactory.Token(SyntaxKind.InternalKeyword),
                    SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                .WithParameterList(parametersList)
                .WithBody(returnStatement);

            return method;
        }


        public static SyntaxNode Namespace(string name, MemberDeclarationSyntax m)
        {
            return SyntaxFactory.NamespaceDeclaration(name.AsIdentifierName())
                .AddUsings("System".AsUsing())
                .AddUsings("System.Runtime.CompilerServices".AsUsing())
                .AddMembers(m);
        }

        private static ParameterListSyntax GetParameters(MethodInfo m)
        {
            var parameters = m.GetParameters();
            var parametersSyntax = parameters.ConvertAll(p => p.AsInternalParameter()).ToList();

            if (!m.IsStatic && !m.IsConstructor)
                parametersSyntax.Insert(0, ToInternalParameter(m.DeclaringType, referenceName));

            var sepSyntaxList = new SeparatedSyntaxList<ParameterSyntax>();
            sepSyntaxList = sepSyntaxList.AddRange(parametersSyntax);

            return SyntaxFactory.ParameterList(sepSyntaxList);
        }

        private static ParameterSyntax ToInternalParameter(Type t, string name)
        {
            return SyntaxFactory.Parameter(name.AsToken())
                    .WithType(InternalNameHelper.GetNameClean(t).AsTypeSyntax());
        }

        private static ArgumentListSyntax GetArguments(MethodInfo m)
        {
            var parameters = m.GetParameters();
            var pList = parameters.ConvertAll(p => InternalNameHelper.GetArgNameClean(p).AsArgument());
            return SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(pList));
        }
    }
}
