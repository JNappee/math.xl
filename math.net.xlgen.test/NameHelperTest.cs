using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace math.net.xlgen.test
{
    [TestClass]
    public class NameHelperTest
    {
        [TestMethod]
        public void TestGetTypeNameClean()
        {
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Matrix<System.Double>", NameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Matrix<double>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Matrix<System.Double>", NameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Matrix<>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Vector<System.Double>", NameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Vector<double>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Vector<System.Double>", NameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Vector<>)));
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Vector<System.Double>[]", NameHelper.GetNameClean(typeof(MathNet.Numerics.LinearAlgebra.Vector<double>[])));
            Assert.AreEqual("void", NameHelper.GetNameClean(typeof(void)));
            Assert.AreEqual("System.Collections.Generic.IList<System.Int64>", NameHelper.GetNameClean(typeof(IList<Int64>)));
            Assert.AreEqual("System.Func<System.Double,System.Double>", NameHelper.GetNameClean(typeof(Func<double, double>)));
            Assert.AreEqual("System.Tuple<System.Double,System.Double>", NameHelper.GetNameClean(typeof(Tuple<double,double>)));
        }

        [TestMethod]
        public void TestSparseVector()
        {
            Assert.AreEqual("MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double>", NameHelper.GetNameClean(typeof( MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<>)));
        }
    }
}
