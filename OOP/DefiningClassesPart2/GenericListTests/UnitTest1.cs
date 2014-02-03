using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddingElements()
        {
            GenericList<string> generic = new GenericList<string>(2);
            generic.AddElement("Pesho");
            generic.AddElement("Gosho");
            Assert.AreEqual("[Pesho, Gosho]", generic.ToString());
        }
        [TestMethod]
        public void AutoGrowTest()
        {
            GenericList<string> generic = new GenericList<string>(2);
            generic.AddElement("Pesho");
            generic.AddElement("Gosho");
            generic.AddElement("Kircho");
            Assert.AreEqual(4, generic.Array.Length);
        }
        [TestMethod]
        public void AutoGrowTest2()
        {
            //two times autogrow
            GenericList<int> generic = new GenericList<int>(2);
            generic.AddElement(1);
            generic.AddElement(2);
            generic.AddElement(3);
            generic.AddElement(4);
            generic.AddElement(5);
            Assert.AreEqual(8, generic.Array.Length);
        }
        [TestMethod]
        public void InsertTest()
        {
            GenericList<string> generic = new GenericList<string>(2);
            generic.AddElement("Pesho");
            generic.AddElement("Gosho");
            generic.AddElement("Kircho");
            generic.InsertAtIndex("Vlado", 0);
            Assert.AreEqual("[Vlado, Pesho, Gosho, Kircho]", generic.ToString());
        }
        [TestMethod]
        public void InsertWithAutoGrowTest()
        {
            GenericList<string> generic = new GenericList<string>(2);
            generic.AddElement("Pesho");
            generic.AddElement("Gosho");
            generic.AddElement("Kircho");
            generic.InsertAtIndex("Vlado", 0);
            generic.InsertAtIndex("Blagoi", 1);
            Assert.AreEqual("[Vlado, Blagoi, Pesho, Gosho, Kircho, (null), (null), (null)]", generic.ToString());
        }
        [TestMethod]
        public void RemovingElementTest()
        {
            GenericList<string> generic = new GenericList<string>(2);
            generic.AddElement("Pesho");
            generic.AddElement("Gosho");
            generic.RemoveAtIndex(1);
            Assert.AreEqual("[Pesho, (null)]", generic.ToString());
        }
        [TestMethod]
        public void FindElementTest()
        {
            GenericList<string> generic = new GenericList<string>(2);
            generic.AddElement("Pesho");
            generic.AddElement("Gosho");
            generic.AddElement("Kircho");
            int index = generic.FindElement("Kircho");
            Assert.AreEqual(2, index);
        }
        [TestMethod]
        public void GettingElementTest()
        {
            GenericList<string> generic = new GenericList<string>(2);
            generic.AddElement("Pesho");
            generic.AddElement("Gosho");
            generic.AddElement("Kircho");
            string element = generic.GetElement(0);
            Assert.AreEqual("Pesho", element);
        }
        [TestMethod]
        public void IndexerTest()
        {
            GenericList<string> generic = new GenericList<string>(2);
            generic.AddElement("Pesho");
            generic.AddElement("Gosho");
            generic.AddElement("Kircho");
            generic[0] = "Vlado";
            Assert.AreEqual("Vlado", generic[0]);
        }
        [TestMethod]
        public void MaxElement()
        {
            GenericList<string> generic = new GenericList<string>(2);
            generic.AddElement("Pesho");
            generic.AddElement("Gosho");
            generic.AddElement("Kircho");
            string max = generic.Max();
            Assert.AreEqual("Pesho", max);
        }
        [TestMethod]
        public void MinElement()
        {
            GenericList<int> generic = new GenericList<int>(400);
            generic.AddElement(5);
            generic.AddElement(900);
            generic.AddElement(-1);
            generic.AddElement(0);
            int min = generic.Min();
            Assert.AreEqual(-1, min);
        }
        [TestMethod]
        public void ClearTest()
        {
            GenericList<int> generic = new GenericList<int>(40);
            generic.AddElement(5);
            generic.AddElement(900);
            generic.InsertAtIndex(9, 17);
            generic.AddElement(-1);
            generic.AddElement(0);
            generic.ClearArray();
            for (int i = 0; i < generic.Length; i++)
            {
                Assert.AreEqual(generic[i], 0);
            }            
        }
        [TestMethod]
        public void ClearStringsTest()
        {
            GenericList<string> generic = new GenericList<string>(40);
            for (int i = 0; i < generic.Length; i++)
            {
                generic[i] = "TEST";
            }
            generic.ClearArray();
            for (int i = 0; i < generic.Length; i++)
            {
                Assert.AreEqual(generic[i], null);
            }
        }
    }
}
