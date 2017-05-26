using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using Microsoft.CodeAnalysis.Formatting;

namespace math.net.xlgen.test
{
    [TestClass]
    public class GenExcelTest
    {
        [TestMethod]
        public void TestMatrixClone()
        {
            var t = typeof(MathNet.Numerics.LinearAlgebra.Matrix<System.Double>);
            var m = t.GetMethod("Clone");

            var mds = GenExcelExports.Generate(Conf.Internal_Namespace + "." + Conf.Internal_ClassName,
                   t, m, new Dictionary<MethodInfo, string>());

            var code = GetCode(mds);

            var expected =
@"[ExcelFunction(Name = ""MN.LinearAlgebra.Matrix.Clone"")]
public static object LinearAlgebra_Matrix_Clone([ExcelArgument(Name = ""_Name"", Description = ""Name of the result object of type [MathNet.Numerics.LinearAlgebra.Matrix]"")] System.String _Name, [ExcelArgument(Name = ""_objString"", Description = ""Reference object of type [MathNet.Numerics.LinearAlgebra.Matrix]"")] System.String _objString)
            {
                try
                {
                    var _obj = Graph.Instance.Get<MathNet.Numerics.LinearAlgebra.Matrix<System.Double>>(_objString);
                    var res = math.net.xladdin.generated.Internal.LinearAlgebra_Matrix_Clone_Internal(_obj);
                    return Graph.Instance.Add(res, _Name);
                }
                catch (Exception ex)
                {
                    return Error.ExcelHandle(ex);
                }
            }";

            Assert.IsTrue(code == expected);
        }

        [TestMethod]
        public void TestDifferentiate()
        {
            var t = typeof(MathNet.Numerics.Differentiate);
            var m = t.GetMethod("Points");

            var mds = GenExcelExports.Generate(Conf.Internal_Namespace + "." + Conf.Internal_ClassName,
                   t, m, new Dictionary<MethodInfo, string>());

            var code = GetCode(mds);

            var expected = 
@"[ExcelFunction(Name = ""MN.Differentiate.Points"", Description = @""Initialized a NumericalDerivative with the given points and center."")]
public static object Differentiate_Points([ExcelArgument(Name = ""_Name"", Description = ""Name of the result object of type [MathNet.Numerics.Differentiation.NumericalDerivative]"")] System.String _Name, [ExcelArgument(Name = ""points"")] System.Int32 points, [ExcelArgument(Name = ""center"")] System.Int32 center)
{
    try
    {
        var res = math.net.xladdin.generated.Internal.Differentiate_Points_Internal(points, center);
        return Graph.Instance.Add(res, _Name, points, center);
    }
    catch (Exception ex)
    {
        return Error.ExcelHandle(ex);
    }
}";

            Assert.IsTrue(code == expected);
        }

        private static string GetCode(MemberDeclarationSyntax method)
        {
            var cw = new AdhocWorkspace();
            cw.Options.WithChangedOption(CSharpFormattingOptions.IndentBraces, true);
            var code = Formatter.Format(method, cw);
            return code.ToString();
        }
    }
}
