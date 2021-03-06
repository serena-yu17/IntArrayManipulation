using IntArrayManipulation.Controllers;
using IntArrayManipulation.Operations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayManipTester
{
    [TestClass]
    public class ArrayManipTester
    {
        ArrayCalcController controller = new ArrayCalcController();

        [TestMethod]
        public void reverseTestMethod1()
        {
            int[] testArr = null;
            ArrayManipService.Reverse(testArr);
            CollectionAssert.AreEqual(testArr, null);
        }

        [TestMethod]
        public void reverseTestMethod2()
        {
            int[] testArr = new int[] { 0 };
            ArrayManipService.Reverse(testArr);
            CollectionAssert.AreEqual(testArr, new int[] { 0 });
        }

        [TestMethod]
        public void reverseTestMethod3()
        {
            int[] testArr = new int[] { 0, 1, 2, 3, 4 };
            ArrayManipService.Reverse(testArr);
            CollectionAssert.AreEqual(testArr, new int[] { 4, 3, 2, 1, 0 });
        }

        [TestMethod]
        public void reverseTestMethod4()
        {
            int[] testArr = new int[] { 0, 1, 2, 3 };
            ArrayManipService.Reverse(testArr);
            CollectionAssert.AreEqual(testArr, new int[] { 3, 2, 1, 0 });
        }

        [TestMethod]
        public void reverseTestMethod5()
        {
            int[] testArr = new int[] { 4, 3, 2, 1, 0 };
            ArrayManipService.Reverse(testArr);
            CollectionAssert.AreEqual(testArr, new int[] { 0, 1, 2, 3, 4 });
        }

        [TestMethod]
        public void reverseTestMethod6()
        {
            int[] testArr = new int[] { 4, 3, 2, 1 };
            ArrayManipService.Reverse(testArr);
            CollectionAssert.AreEqual(testArr, new int[] { 1, 2, 3, 4 });
        }

        [TestMethod]
        public void reverseTestMethod7()
        {
            int[] testArr = new int[] { 4, 2, 3, 1, 5 };
            ArrayManipService.Reverse(testArr);
            CollectionAssert.AreEqual(testArr, new int[] { 5, 1, 3, 2, 4 });
        }

        [TestMethod]
        public void delTestMethod8()
        {
            int[] testArr = null;
            ArrayManipService.DeletePart(testArr, 1);
            CollectionAssert.AreEqual(testArr, null);
        }

        [TestMethod]
        public void delTestMethod9()
        {
            int[] testArr = new int[] { 0 };
            ArrayManipService.DeletePart(testArr, 1);
            CollectionAssert.AreEqual(testArr, new int[] { 0 });
        }

        [TestMethod]
        public void delTestMethod10()
        {
            int[] testArr = new int[] { 0 };
            var result = ArrayManipService.DeletePart(testArr, 0);
            CollectionAssert.AreEqual(result, new int[0]);
        }

        [TestMethod]
        public void delTestMethod11()
        {
            int[] testArr = new int[] { 0, 1, 4, 7, 9, 100 };
            var result = ArrayManipService.DeletePart(testArr, 7);
            CollectionAssert.AreEqual(result, testArr);
        }

        [TestMethod]
        public void delTestMethod12()
        {
            int[] testArr = new int[] { 0, 1, 4, 7, 9, 100 };
            var result = ArrayManipService.DeletePart(testArr, 5);
            CollectionAssert.AreEqual(result, new int[] { 0, 1, 4, 7, 9 });
        }

        [TestMethod]
        public void delTestMethod13()
        {
            int[] testArr = new int[] { 0, 1, 4, 7, 9, 100 };
            var result = ArrayManipService.DeletePart(testArr, 0);
            CollectionAssert.AreEqual(result, new int[] { 1, 4, 7, 9, 100 });
        }

        [TestMethod]
        public void delTestMethod14()
        {
            int[] testArr = new int[] { 0, 1, 4, 7, 9, 100 };
            var result = ArrayManipService.DeletePart(testArr, 3);
            CollectionAssert.AreEqual(result, new int[] { 0, 1, 4, 9, 100 });
        }
    }
}
