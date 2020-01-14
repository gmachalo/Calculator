using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticsCalc.Tests
{
    [TestClass()]
    public class StatisticsCalcTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            MeanCalc statsCal = new MeanCalc();
            double[] values = { 1, 2 };
            var mean = statsCal.Mean(values);
            Assert.AreEqual(1.5, mean);
        }
    }
}