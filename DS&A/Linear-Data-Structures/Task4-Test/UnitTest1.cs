using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
namespace Task4_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsWorkingProperly()
        {
            List<int> list = new List<int>{1, 2, 2, 2, 3, 2, 4, 5,5,5,5, 7, 8};

            var expectedElement = 5;
            var expectedCount = 4;
            Assert.AreEqual(expectedElement,5);
            Assert.AreEqual(expectedCount,4);
            
        }
    }
}
