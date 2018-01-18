using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonWay.Controllers;


namespace LemonWay.Tests
{  
        [TestClass]
        public class FibonacciTests
        {
            [TestMethod]
            public void TestWith10()
            {
                ServiceController service = new ServiceController();
                Assert.AreEqual(service.Fibonacci(10), 55);
            }

            [TestMethod]
            public void TestWith20()
            {
                ServiceController service = new ServiceController();
                Assert.AreEqual(service.Fibonacci(20), 6765);
            }

            [TestMethod]
            public void TestWith0()
            {
            ServiceController service = new ServiceController();
            Assert.AreEqual(service.Fibonacci(0), -1);
            }

            [TestMethod]
            public void TestWith1()
            {
            ServiceController service = new ServiceController();
            Assert.AreEqual(service.Fibonacci(1), 1);
            }

        }
}
