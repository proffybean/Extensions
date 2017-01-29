using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Extensions.Tests
{
    [TestClass]
    public class ListExtensionTests
    {
        [TestMethod]
        public void IsEmptyMethod_Should_ReturnBool()
        {
            List<int> intList = new List<int>() { 1, 3, 5 };
            List<int> emptyList = new List<int>();

            Assert.IsFalse(intList.IsEmpty());
            Assert.IsTrue(emptyList.IsEmpty());
        }
    }
}
