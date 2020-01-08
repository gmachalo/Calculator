using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalcTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calc calculator = new Calc();

            int c = calculator.Add(1, 2);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.result);

        }
        [TestMethod()]
        public void DivTest()
        {
            Calc calculator = new Calc();

            int c = calculator.Div(2, 1);

            Assert.AreEqual(2, c);
            Assert.AreEqual(2, calculator.result);

        }
    }
}