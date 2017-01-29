using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Tests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void ReverseMe_ShouldReverseString()
        {
            string s = "Jeffrey";
            Assert.AreEqual("yerffeJ", s.ReverseMe());
        }
    }
}
