using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxUsingGenerics;
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
    }
}
