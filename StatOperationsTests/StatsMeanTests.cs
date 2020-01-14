using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatsMeanTests
    {
        [TestMethod()]
        public void MeanIntTest()
        {
            int[] values = { 10, 20, 30 };
            var mean = StatsMean.Mean(values);
            Assert.AreEqual(20, mean);

        }
        [TestMethod()]
        public void MeanDoubleTest()
        {
            double[] values = { 2.0, 3.0, 4.0 };
            var mean = StatsMean.Mean(values);
            Assert.AreEqual(3, mean);

        }
    }
}