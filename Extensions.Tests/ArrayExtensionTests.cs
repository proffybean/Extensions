using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extensions.Tests
{
    [TestClass]
    public class ArrayExtensionTests
    {
        [TestMethod]
        public void ArrayOfInts_Should_ReturnAverage()
        {
            int[] myArray = new int[] { 2, 4, 6 };
            Assert.AreEqual(4, myArray.Average());
        }

        [TestMethod]
        public void ArrayOfInts_Should_ReturnAverage2()
        {
            int[] myArray = new int[] { 2, 4, 6, 7 };
            Assert.AreEqual(4.75, myArray.Average());
        }

        [TestMethod]
        public void ReverseOfStringArray_ShouldBe_Correct()
        {
            string[] myArray = new string[] { "the", "quick", "brown", "fox" };
            string[] myReversedArray = myArray.Reverse();
            string[] expectedArray = new string[] { "fox", "brown", "quick", "the" };

            CollectionAssert.AreEqual(expectedArray, myReversedArray);
        }

        [TestMethod]
        public void ReverseOfCharArray_ShouldBe_Correct()
        {
            char[] myArray = new char[] { 'a', 'b', 'c', 'd' };
            var reversedArray = myArray.Reverse();
            char[] expectedArray = new char[] { 'd', 'c', 'b', 'a' };

            CollectionAssert.AreEqual(expectedArray, reversedArray);
        }

        [TestMethod]
        public void ReverseOfGenericArray_ShouldBe_Correct()
        {
            int[] myArray = new int[] { 0, 1, 2, 3, 4, 5 };
            var reversedArray = myArray.Reverse();
            int[] expectedArray = new int[] { 5, 4, 3, 2, 1, 0 };

            CollectionAssert.AreEqual(expectedArray, reversedArray);
        }

        [TestMethod]
        public void ReverseOfDoubleArray_ShouldBe_Correct()
        {
            double[] myArray = new double[] { 0, 1.3, 2.0, 3.01, 4.5, 5.99084 };
            var reversedArray = myArray.ReverseWithStack();
            double[] expectedArray = new double[] { 5.99084, 4.5, 3.01, 2.0, 1.3, 0 };

            CollectionAssert.AreEqual(expectedArray, reversedArray);
        }

        [TestMethod]
        public void ReverseOfIntArray_ShouldBe_Correct2()
        {
            int[] myArray = new int[] { 0, 5, 10, -3};
            var reversedArray = myArray.ReverseWithForeachLoop();
            int[] expectedArray = new int[] { -3, 10, 5, 0 };

            CollectionAssert.AreEqual(expectedArray, reversedArray);
        }

        [TestMethod]
        public void ForEachLoop_Should_LoopThrough()
        {
            string s = "hello";
            char[] arr = s.ToCharArray();
            arr.ForEachItem(x => Console.Write(x + " "));
        }

        [TestMethod]
        public void ReverseAnArrayOfInts_ShouldWork_WithMyForEachItemExt()
        {
            string s = "hello";
            char[] arr = s.ToCharArray();
            CollectionAssert.AreEqual("olleh".ToCharArray(), arr.ReverseWithForEachItemExtension());
        }
    }
}
