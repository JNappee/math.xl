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

    public abstract class TypeHelperWithMapping : TypeHelper
    {
        public override bool NeedsMapping()
        {
            return true;
        }

        public override string ToArgName(string name)
        {
            return name + "_obj";
        }
    }

    [Mapper(typeof(System.Numerics.Complex))]
    public sealed class TypeHelperComplex : TypeHelperWithMapping
    {
        public static TypeHelperComplex Instance { get; } = new TypeHelperComplex();
        private TypeHelperComplex() { }

        public override ExpressionStatementSyntax[] ToExpression(string name)
        {
            return new ExpressionStatementSyntax[]
            {
                SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                    ("var " + name + "_obj").AsExpression(), ("ComplexMapper.FromString(" + name + ")").AsExpression()))
                            .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed)
            };
        }
        public override string ExcelParameterTypeName()
        {
            return "System.String";
        }

        public override List<StatementSyntax> HandleReturnType(ExpressionSyntax functionCall)
        {
            // var res = functioncall();
            var fReturn = SyntaxFactory.ExpressionStatement(SyntaxFactory.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                "var res ".AsExpression(), functionCall))
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            // return MyMapper.ToString(res);
            var formatReturn = SyntaxFactory.ParseStatement("return ComplexMapper.ToString(res);")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            return new List<StatementSyntax>() { fReturn, formatReturn };
        }
    }

    [Mapper(typeof(System.Numerics.Complex[]))]
    public sealed class TypeHelperComplexArray : TypeHelperWithMapping
    {
        public static TypeHelperComplexArray Instance { get; } = new TypeHelperComplexArray();
        private TypeHelperComplexArray() { }

        public override bool NeedsMapping()
        {
            return true;
        }
        public override ExpressionStatementSyntax[] ToExpression(string name)
        {
            return new ExpressionStatementSyntax[]
            {
               ("var range_"+name+" = RangeHelpers.ObjectToRange(" + name + ")").AsExpressionStatement(),
               ("var complexStrings_"+name+" = RangeHelpers.RangeToStringArray(range_" + name + ")").AsExpressionStatement(),
               ("var " + ToArgName(name) + " = Array.ConvertAll(complexStrings_" + name + ", ComplexMapper.FromString)").AsExpressionStatement()
            };
        }

        public override List<StatementSyntax> HandleReturnType(ExpressionSyntax functionCall)
        {
            //var caller = XlCall.Excel(XlCall.xlfCaller) as ExcelReference;
            var callerXl = SyntaxFactory.ParseStatement("var caller = XlCall.Excel(XlCall.xlfCaller) as ExcelReference;")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            // var res = functioncall();
            var fReturn = SyntaxFactory.ExpressionStatement(SyntaxFactory.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                "var res ".AsExpression(), functionCall))
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            //var tmp = Array.ConvertAll(res, ComplexMapper.ToString);
            var complexStrings = SyntaxFactory.ParseStatement("var complexStrings = Array.ConvertAll(res, ComplexMapper.ToString);")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            //return Format.Return(res, caller, options);
            var formatReturn = SyntaxFactory.ParseStatement("return Format.Return(complexStrings, caller, excel_options);")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            return new List<StatementSyntax>() { callerXl, fReturn, complexStrings, formatReturn };
        }

        public override string ExcelParameterTypeName()
        {
            return "object";
        }

        protected override bool NeedsAllowReference()
        {
            return true;
        }
        public override bool AddOptionsExcelParameter()
        {
            return true;
        }
    }


    [Mapper(typeof(IEnumerable<System.Numerics.Complex>))]
    public sealed class TypeHelperComplexEnum : TypeHelperWithMapping
    {
        public static TypeHelperComplexEnum Instance { get; } = new TypeHelperComplexEnum();
        private TypeHelperComplexEnum() { }

        public override bool NeedsMapping()
        {
            return true;
        }
        public override ExpressionStatementSyntax[] ToExpression(string name)
        {
            return new ExpressionStatementSyntax[]
            {
               ("var range_"+name+" = RangeHelpers.ObjectToRange(" + name + ")").AsExpressionStatement(),
               ("var complexStrings_"+name+" = RangeHelpers.RangeToStringArray(range_" + name + ")").AsExpressionStatement(),
               ("var " + ToArgName(name) + " = Array.ConvertAll(complexStrings_" + name + ", ComplexMapper.FromString)").AsExpressionStatement()
            };
        }

        public override List<StatementSyntax> HandleReturnType(ExpressionSyntax functionCall)
        {
            //var caller = XlCall.Excel(XlCall.xlfCaller) as ExcelReference;
            var callerXl = SyntaxFactory.ParseStatement("var caller = XlCall.Excel(XlCall.xlfCaller) as ExcelReference;")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            // var res = functioncall();
            var fReturn = SyntaxFactory.ExpressionStatement(SyntaxFactory.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                "var res ".AsExpression(), functionCall))
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            //var tmp = Array.ConvertAll(res, ComplexMapper.ToString);
            var complexStrings = SyntaxFactory.ParseStatement("var complexStrings = res.Select(ComplexMapper.ToString);")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            //return Format.Return(res, caller, options);
            var formatReturn = SyntaxFactory.ParseStatement("return Format.Return(complexStrings, caller, excel_options);")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            return new List<StatementSyntax>() { callerXl, fReturn, complexStrings, formatReturn };
        }

        public override string ExcelParameterTypeName()
        {
            return "object";
        }

        protected override bool NeedsAllowReference()
        {
            return true;
        }
        public override bool AddOptionsExcelParameter()
        {
            return true;
        }
    }

    [Mapper(typeof(Int32[]))]
    [Mapper(typeof(IEnumerable<Int32>))]
    public sealed class TypeHelperInt32Array : TypeHelperWithMapping
    {
        public static TypeHelperInt32Array Instance { get; } = new TypeHelperInt32Array();
        private TypeHelperInt32Array() { }

        public override ExpressionStatementSyntax[] ToExpression(string name)
        {
            return new ExpressionStatementSyntax[]
            {
               ("var range = RangeHelpers.ObjectToRange(" + name + ")").AsExpressionStatement(),
               ("var " + ToArgName(name) + " = RangeHelpers.RangeToIntArray(range)").AsExpressionStatement()
            };
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

        protected override bool NeedsAllowReference()
        {
            return true;
        }

        public override string ExcelParameterTypeName()
        {
            return "object";
        }


        public override bool AddOptionsExcelParameter()
        {
            return true;
        }
    }

    [Mapper(typeof(MathNet.Numerics.LinearAlgebra.Matrix<Double>))]
    public sealed class TypeHelperMatrixDoubleArray : TypeHelperWithMapping
    {
        public static TypeHelperMatrixDoubleArray Instance { get; } = new TypeHelperMatrixDoubleArray();
        private TypeHelperMatrixDoubleArray() { }

        public override ExpressionStatementSyntax[] ToExpression(string name)
        {
            return new ExpressionStatementSyntax[]
            {
               ("var " + ToArgName(name) + " = MathNet.Numerics.LinearAlgebra.Matrix<double>.Build.DenseOfArray(" + name + ")").AsExpressionStatement()
            };
        }

        public override List<StatementSyntax> HandleReturnType(ExpressionSyntax functionCall)
        {
            //var caller = XlCall.Excel(XlCall.xlfCaller) as ExcelReference;
            var callerXl = SyntaxFactory.ParseStatement("var caller = XlCall.Excel(XlCall.xlfCaller) as ExcelReference;")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            // var res = functioncall();
            var fReturn = SyntaxFactory.ExpressionStatement(SyntaxFactory.AssignmentExpression(SyntaxKind.SimpleAssignmentExpression,
                "var res ".AsExpression(), functionCall))
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            //return Format.Return(res, caller, options);
            var formatReturn = SyntaxFactory.ParseStatement("return Format.Return(res.ToArray(), caller, excel_options);")
                    .WithTrailingTrivia(SyntaxFactory.CarriageReturnLineFeed);

            return new List<StatementSyntax>() { callerXl, fReturn, formatReturn };
        }

        protected override bool NeedsAllowReference()
        {
            return true;
        }

        public override string ExcelParameterTypeName()
        {
            return "double[,]";
        }

        public override bool AddOptionsExcelParameter()
        {
            return true;
        }
    }
}
