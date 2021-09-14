using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lesson2;
namespace UnitTestSorts
{
    [TestClass]
    public class UnitTest1
    {
        public static bool EqualsArrays(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Sorts.bubbleSort(arr);
            Assert.IsTrue(EqualsArrays(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, arr));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Sorts.bubbleSort(arr);
            Assert.IsTrue(EqualsArrays(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, arr));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] arr = { 5, 3, 6, 3, 2, 8, 6, 8, 9, 0, 11 };
            Sorts.bubbleSort(arr);
            Assert.IsTrue(EqualsArrays(new int[] { 0, 2, 3, 3, 5, 6, 6, 8, 8, 9, 11 }, arr));

        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Sorts.mergeSort(arr);
            Assert.IsTrue(EqualsArrays(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, arr));
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Sorts.mergeSort(arr);
            Assert.IsTrue(EqualsArrays(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, arr));
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] arr = { 5, 3, 6, 3, 2, 8, 6, 8, 9, 0, 11 };
            Sorts.mergeSort(arr);
            Assert.IsTrue(EqualsArrays(new int[] { 0, 2, 3, 3, 5, 6, 6, 8, 8, 9, 11 }, arr));
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(Sorts.BSA(arr, 4), 3);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(Sorts.BSA(arr, 11), -1);
        }
    }
}
