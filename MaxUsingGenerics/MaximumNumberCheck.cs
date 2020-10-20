using System;
using System.Collections.Generic;
using System.Text;

namespace MaxUsingGenerics
{
    public class MaximumNumberCheck
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new ValidationException("firstNumber,secondNumber and thirdNumber are same");
        }

        public static int MaximumDoubleNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new ValidationException("firstNumber,secondNumber and thirdNumber are same");
        }

        public static int MaximumDoubleNumber(double num1, double num2, double num3)
        {
            throw new NotImplementedException();
        }

        public static int MaximumIntegerNumber(double num1, double num2, double num3)
        {
            throw new NotImplementedException();
        }
    }
}
