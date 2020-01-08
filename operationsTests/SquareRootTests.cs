using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly double a = 25.0;

        [TestMethod()]
        public void RootTest()
        {
            Assert.AreEqual(5, SquareRoot.Root(a));
        }
    }
}