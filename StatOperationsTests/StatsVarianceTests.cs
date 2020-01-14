using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatOperations.Tests
{
    [TestClass()]
    public class StatsVarianceTests
    {
        [TestMethod()]
        public void VarianceTest()
        {
            int[] values = { 2, 4, 6, 8 };
            var variance = StatsVariance.Variance(values);
            Assert.AreEqual(5, Helper.Rounding.RoundFiveDecimals(variance));

        }
        [TestMethod()]
        public void VarianceDoubleTest()
        {
            double[] values = { 2.0, 3.0, 4.0 };
            var variance = StatsVariance.Variance(values);
            Assert.AreEqual(0.66667, Helper.Rounding.RoundFiveDecimals(variance));

        }
    }
}