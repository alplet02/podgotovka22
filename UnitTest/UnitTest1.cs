using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MatchLibrary;
 
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(MatchLibrary.Class1.Sum(1, 2), 3);
        }
    }
}
