using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace math.net.xlgen.test
{
    [TestClass]
    public class NameHelperTest
    {
        [TestMethod]
        public void TestGetInternalTypeNameClean()
        {
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Matrix<System.Double>", InternalNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Matrix<double>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Matrix<System.Double>", InternalNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Matrix<>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Vector<System.Double>", InternalNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Vector<double>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Vector<System.Double>", InternalNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Vector<>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Vector<System.Double>[]", InternalNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Vector<double>[])));
            Assert.AreEqual("void", InternalNameHelper.GetNameClean(typeof(void)));
            Assert.AreEqual("System.Collections.Generic.IList<System.Int64>", InternalNameHelper.GetNameClean(typeof(IList<Int64>)));
            Assert.AreEqual("System.Func<System.Double,System.Double>", InternalNameHelper.GetNameClean(typeof(Func<double, double>)));
            Assert.AreEqual("System.Tuple<System.Double,System.Double>", InternalNameHelper.GetNameClean(typeof(Tuple<double, double>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double>", InternalNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<>)));
            Assert.AreEqual("System.Numerics.Complex", InternalNameHelper.GetNameClean(typeof(Complex)));
            Assert.AreEqual("System.Numerics.Complex[]", InternalNameHelper.GetNameClean(typeof(Complex[])));
            Assert.AreEqual("System.Collections.Generic.IEnumerable<System.Numerics.Complex>", InternalNameHelper.GetNameClean(typeof(IEnumerable<Complex>)));
        }


        [TestMethod]
        public void TestGetExcelTypeNameClean()
        {
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Matrix<System.Double>", ExcelNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Matrix<double>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Matrix<System.Double>", ExcelNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Matrix<>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Vector<System.Double>", ExcelNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Vector<double>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Vector<System.Double>", ExcelNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Vector<>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Vector<System.Double>[]", ExcelNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Vector<double>[])));
            Assert.AreEqual("void", ExcelNameHelper.GetNameClean(typeof(void)));
            Assert.AreEqual("System.Collections.Generic.IList<System.Int64>", ExcelNameHelper.GetNameClean(typeof(IList<Int64>)));
            Assert.AreEqual("System.Func<System.Double,System.Double>", ExcelNameHelper.GetNameClean(typeof(Func<double, double>)));
            Assert.AreEqual("System.Tuple<System.Double,System.Double>", ExcelNameHelper.GetNameClean(typeof(Tuple<double, double>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double>", ExcelNameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<>)));
            Assert.AreEqual("System.String", ExcelNameHelper.GetNameClean(typeof(Complex)));
            Assert.AreEqual("System.String[]", ExcelNameHelper.GetNameClean(typeof(Complex[])));
            Assert.AreEqual("System.String[]", ExcelNameHelper.GetNameClean(typeof(IEnumerable<Complex>)));
        }
    }
}
