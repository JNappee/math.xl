using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xlgen
{
    internal static class SyntaxExtensions
    {
        /// <summary>
        /// Generates Internal Parameter
        /// </summary>
        public static ParameterSyntax AsInternalParameter(this ParameterInfo p)
        {
            if (TypeHelper.Handles(p.ParameterType))
                return TypeHelper.Get(p.ParameterType).ToInternalParameter(p);
            return p.Name.AsParameter()
                    .WithType(InternalNameHelper.GetNameClean(p).AsTypeSyntax());
        }

        /// <summary>
        /// Generates Excel Parameter
        /// </summary>
        public static ParameterSyntax AsExcelParameter(this ParameterInfo p, DocFunction doc)
        {
            if (TypeHelper.Handles(p.ParameterType))
                return TypeHelper.Get(p.ParameterType).ToExcelParameter(p, doc);
            return TypeHelper.ToStringObjectExcelParameter(p.Name, doc);
        }

        /// <summary>
        /// Generates type syntax
        /// </summary>
        public static TypeSyntax AsTypeSyntax(this string s)
        {
            return SyntaxFactory.ParseTypeName(s);
        }

        /// <summary>
        /// Generates syntax expression
        /// </summary>
        public static ExpressionSyntax AsExpression(this string s)
        {
            return SyntaxFactory.ParseExpression(s);
        }


        /// <summary>
        /// Generates syntax statement
        /// </summary>
        public static StatementSyntax AsStatement(this string s)
        {
            return SyntaxFactory.ParseStatement(s);
        }


        /// <summary>
        /// Generates expression syntax statement
        /// </summary>
        public static ExpressionStatementSyntax AsExpressionStatement(this string s)
        {
            return SyntaxFactory.ExpressionStatement(SyntaxFactory.ParseExpression(s))
                .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);
        }


        /// <summary>
        /// Generates token
        /// </summary>
        public static ParameterSyntax AsParameter(this string s)
        {
            return SyntaxFactory.Parameter(s.AsToken());
        }

        /// <summary>
        /// Generates token
        /// </summary>
        public static SyntaxToken AsToken(this string s)
        {
            return SyntaxFactory.Identifier(s);
        }

        /// <summary>
        /// Generates identifier name
        /// </summary>
        public static IdentifierNameSyntax AsIdentifierName(this string s)
        {
            return SyntaxFactory.IdentifierName(s);
        }

        /// <summaryargument
        /// Generates identifier
        /// </summary>
        public static ArgumentSyntax AsArgument(this string s)
        {
            return SyntaxFactory.Argument(s.AsIdentifierName());
        }

        /// <summary>
        /// Generates Using syntax
        /// </summary>
        public static UsingDirectiveSyntax AsUsing(this string s)
        {
            return SyntaxFactory.UsingDirective(s.AsIdentifierName());
        }
    }
}
