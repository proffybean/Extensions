using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Tests
{
    [TestClass]
    public class IntExtensionTests
    {
        [TestMethod]
        public void Number9_ShouldBe_PerfectSquare()
        {
            Assert.IsTrue(9.IsPerfectSquare());
        }

        [TestMethod]
        public void Number10_ShouldNotBe_PerfectSquare()
        {
            int myInt = 10;
            Assert.IsFalse(myInt.IsPerfectSquare());
        }

        [TestMethod]
        public void NextInt_ShouldBe_OneMore()
        {
            int firstInt = 5;
            Assert.AreEqual(6, firstInt.NextInt());
        }

        [TestMethod]
        public void NextInt_ShouldBe_OneMore2()
        {
            Assert.AreEqual(11, 10.NextInt());
        }

        [TestMethod]
        public void IsEven_Should_ReturnBool()
        {
            Assert.AreEqual(true, 10.IsEven());
            Assert.AreEqual(false, 3.IsEven());
        }
    }
}
