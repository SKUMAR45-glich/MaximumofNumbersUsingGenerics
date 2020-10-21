using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxUsingGenerics;
using System;

namespace GenericsMaxTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestforMaximumNumber()
        {
            //Arrange
            int[] intArray = { 112, 344, 432, };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            int expected = 432;

            //Act
            int actual = generic.MaxMethod();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestforMaximumDouble()
        {
            //Arrange
            double[] doubleArray = { 11.2, 34.4, 4.32 };
            GenericMaximum<double> generic = new GenericMaximum<double>(doubleArray);
            double expected = 34.4;

            //Act
            double actual = generic.MaxMethod();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestforMaximumString()
        {
            //Arrange
            string[] stringArray = { "Apple", "Peach", "Banana" };
            GenericMaximum<string> generic = new GenericMaximum<string>(stringArray);
            string expected = "Banana";

            //Act
            string actual = generic.MaxMethod();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
