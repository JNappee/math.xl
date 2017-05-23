using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math.net.xlgen
{
    internal static class SyntaxExtensions
    {

        /// <summary>
        /// Generates type syntax
        /// </summary>
        public static TypeSyntax AsTypeSyntax(this string s)
        {
            return SyntaxFactory.ParseTypeName(s);
        }

        /// <summary>
        /// Generates identifier
        /// </summary>
        public static IdentifierNameSyntax AsIdentifier(this string s)
        {
            return SyntaxFactory.IdentifierName(s);
        }

        /// <summary>
        /// Generates identifier
        /// </summary>
        public static ArgumentSyntax AsArgument(this string s)
        {
            return SyntaxFactory.Argument(s.AsIdentifier());
        }

        /// <summary>
        /// Generates Using syntax
        /// </summary>
        public static UsingDirectiveSyntax AsUsing(this string s)
        {
            return SyntaxFactory.UsingDirective(s.AsIdentifier());
        }
    }
}
