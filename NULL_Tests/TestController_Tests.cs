using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NULL_API.Controllers;

namespace NULL_Tests
{
    [TestClass]
    public class TestController_Tests
    {
        [TestMethod]
        public void Calculate_Test()
        {
            TestController Test = new TestController();
            string result = Test.Calculate(1, 2);
            Assert.AreEqual("3", result);

        }
    }
}
