using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensions.Samples;

namespace Extensions.Tests
{
    [TestClass]
    public class LegacyExtensionsTests
    {
        [TestMethod]
        public void ToLegacyFormat_ShouldHonor_CurrentYear()
        {
            var dateTime = new DateTime(1920, 12, 31);
            Assert.AreEqual("0201231", dateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyFormat_ShouldHonor_21stCentury()
        {
            var dateTime = new DateTime(2016, 12, 31);
            Assert.AreEqual("1161231", dateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void DateTime_ShouldBeConverted_ToStartOfDay()
        {
            var datetime = new DateTime(2016, 5, 3, 9, 30, 1);
            var expectedDateTimeResults = 
                new DateTime(datetime.Year, datetime.Month, datetime.Day);
            Assert.AreEqual(expectedDateTimeResults, datetime.StartOfDay());
        }
    }
}
