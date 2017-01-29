using Extensions;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace Extensions.Tests
{
    [TestClass]
    public class IEnumerableExtensionTests
    {
        [TestMethod]
        public void NumExtMethod_Should_CountItems()
        {
            IEnumerable<int> collection = new List<int> { 1, 2, 3, 4, 5 };

            Assert.AreEqual(5, collection.Number());
        }

        [TestMethod]
        public void ForEachItemExtMethod_Should_Iterate()
        {
            IEnumerable<int> collection = new List<int> { 1, 2, 3, 4, 5 };
            collection.ForEachItem(x => WriteLine(x));

            Assert.AreEqual(5, collection.ForEachItem(x => WriteLine(x)));
        }

        [TestMethod]
        public void ForEachItemExtMethod_Should_Iterate_WithAction()
        {
            Action<int> print = MyPrint;
            IEnumerable<int> collection = new List<int> { 20, 40, 60 };
            collection.ForEachItem(print);

            Assert.AreEqual(3, collection.ForEachItem(x => WriteLine(x)));
        }

        public static void MyPrint(int s)
        {
            WriteLine(s);
        }

        [TestMethod]
        public void HasExtMethod_Should_Iterate()
        {
            IEnumerable<string> collection = new List<string> { "Jim", "Kelly", "Trevor", "Shelly", "Kim" };
            var ellyCol = collection.Has("elly");
            var imCol = collection.Has("im");
            var steinCol = collection.Has("stein");
            IEnumerable<string> ellyExpected = new[] { "Kelly", "Shelly" };

            Assert.AreEqual(0, steinCol.Number());
            Assert.AreEqual(2, ellyCol.Number());
        }

        [TestMethod]
        public void UltimateExtMethod_Should_SelectLastString()
        {
            IEnumerable<string> collection = new List<string>
            {
                "Washington", "Oregon", "Colorado", "Arizona", "California"
            };

            Assert.AreEqual("California", collection.Ultimate());
        }

        [TestMethod]
        public void UltimateExtMethod_Should_SelectLastString_InSortedCollection()
        {
            IEnumerable<string> collection = new List<string>
            {
                "Washington", "Oregon", "Colorado", "Arizona", "California"
            };

            var sortedCollection = from state in collection
                                   orderby state
                                   select state;

            Assert.AreEqual("Washington", sortedCollection.Ultimate());
        }

        [TestMethod]
        public void UltimateExtMethod_Should_SelectLastString_InSortedCollection2()
        {
            IEnumerable<string> collection = new List<string>
            {
                "Washington", "Oregon", "Colorado", "Arizona", "California"
            };

            var sortedCollection = collection.OrderByDescending(s => s);

            Assert.AreEqual("Arizona", sortedCollection.Ultimate());
        }

        [TestMethod]
        public void Penultimate_Should_ReturnSecondToLastElement()
        {
            IEnumerable<DateTime> collection = new List<DateTime>
            {
                DateTime.Now,
                DateTime.Now.AddSeconds(1),
                DateTime.Now.AddMinutes(-5),
                DateTime.Now.AddHours(1),
                DateTime.Now.AddMonths(-2),
                DateTime.Now.AddYears(-1)
            };
            var expected = collection.ElementAt(4);

            Assert.AreEqual(expected, collection.Penultimate());
        }

        [TestMethod]
        public void Penultimate_Should_ReturnSecondToLastElement_InSortedCollection()
        {
            DateTime second = DateTime.Now.AddSeconds(5);

            IEnumerable<DateTime> collection = new List<DateTime>
            {
                DateTime.Now,
                second,
                DateTime.Now.AddMinutes(-5),
                DateTime.Now.AddHours(1),
                DateTime.Now.AddMonths(-2),
                DateTime.Now.AddYears(-1)
            };

            var sortedCollection = collection.OrderBy(d => d);

            Assert.AreEqual(second, sortedCollection.Penultimate());
        }

        [TestMethod]
        public void Antepenultimate_Should_SelectThirdToLast()
        {
            IEnumerable<string> collection = new List<string>
            {
                "Washington", "Oregon", "Colorado", "Arizona", "California"
            };

            Assert.AreEqual("Colorado", collection.Antepenultimate());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Antepenultimate_ShouldThrow_SelectThirdToLast()
        {
            IEnumerable<string> collection = new List<string>
            {
                "Washington", "Oregon"
            };

            Assert.AreEqual("Colorado", collection.Antepenultimate());
        }
    }
}
