using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxUsingGenerics;
using System;

namespace GenericsMaxTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(5, 8, 9)]
        public void TestforMaximumNumber(int num1, int num2, int num3)
        {
            //Arrange
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int expected = 9;

            //Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(num1, num2, num3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, 9, 8)]
        public void TestforMaxatsecond(int num1, int num2, int num3)
        {
            //Arrange
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int expected = 9;

            //Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(num1, num2, num3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, 8, 9)]
        public void TestforMaxatthird(int num1, int num2, int num3)
        {
            //Arrange
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int expected = 9;

            //Act
            int actual = MaximumNumberCheck.MaximumIntegerNumber(num1, num2, num3);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(9,9,9)]
        public void TestforallSame(int num1, int num2, int num3)
        {
            //Arrange
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            string expected = "firstNumber,secondNumber and thirdNumber are same";
            string actual;
            //Act
            try
            {
                actual = Convert.ToString(MaximumNumberCheck.MaximumIntegerNumber(num1, num2, num3)); 
            }
            catch (ValidationException e)
            {
                actual = e.Message;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
