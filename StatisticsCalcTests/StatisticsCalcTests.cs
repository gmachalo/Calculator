using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalc;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalc.Tests
{
    [TestClass()]
    public class StatisticsCalcTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            StatisticsCalc statsCal = new StatisticsCalc();
            double[] values = { 1, 2 };
            var mean = statsCal.Mean(values);
            Assert.AreEqual(1.5, mean);
        }
    }
}