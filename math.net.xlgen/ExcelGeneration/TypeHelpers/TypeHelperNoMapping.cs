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

    public abstract class TypeHelperNoMapping : TypeHelper
    {
        public override bool NeedsMapping()
        {
            return false;
        }

        public override ExpressionStatementSyntax[] ToExpression(string name)
        {
            throw new NotImplementedException("This should never be called.");
        }

        public override string ToArgName(string name)
        {
            return name;
        }
    }

    [Mapper(typeof(Double))]
    public sealed class TypeHelperDouble : TypeHelperNoMapping
    {
        public static TypeHelperDouble Instance { get; } = new TypeHelperDouble();
        private TypeHelperDouble() { }

        public override string ExcelParameterTypeName()
        {
            return "System.Double";
        }
    }

    [Mapper(typeof(Double[]))]
    [Mapper(typeof(IEnumerable<Double>))]
    public sealed class TypeHelperDoubleArray : TypeHelperNoMapping
    {
        public static TypeHelperDoubleArray Instance { get; } = new TypeHelperDoubleArray();
        private TypeHelperDoubleArray() { }

        public override string ExcelParameterTypeName()
        {
            return "System.Double[]";
        }

        public override List<StatementSyntax> HandleReturnType(ExpressionSyntax functionCall)
        {
            //var caller = XlCall.Excel(XlCall.xlfCaller) as ExcelReference;
            var callerXl = SyntaxFactory.ParseStatement("var caller = XlCall.Excel(XlCall.xlfCaller) as ExcelReference;")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            // var res = functioncall();
            var fReturn = SyntaxFactory.ExpressionStatement(SyntaxFactory.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                "var res".AsExpression(), functionCall))
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            //return Format.Return(res, caller, options);
            var formatReturn = SyntaxFactory.ParseStatement("return Format.Return(res, caller, excel_options);")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            return new List<StatementSyntax>() { callerXl, fReturn, formatReturn };
        }

        public override bool AddOptionsExcelParameter()
        {
            return true;
        }
    }


    [Mapper(typeof(Int32))]
    public sealed class TypeHelperInt32 : TypeHelperNoMapping
    {
        public static TypeHelperInt32 Instance { get; } = new TypeHelperInt32();
        private TypeHelperInt32() { }

        public override string ExcelParameterTypeName()
        {
            return "System.Int32";
        }
    }

    [Mapper(typeof(Boolean))]
    public sealed class TypeHelperBoolean : TypeHelperNoMapping
    {
        public static TypeHelperBoolean Instance { get; } = new TypeHelperBoolean();
        private TypeHelperBoolean() { }

        public override string ExcelParameterTypeName()
        {
            return "System.Boolean";
        }
    }
}
