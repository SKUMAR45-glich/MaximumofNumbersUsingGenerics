using System;
using System.Collections.Generic;

namespace MaxUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            /*int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            double outputdouble = MaximumNumberCheck.MaximumDoubleNumber(11.1, 22.2, 33.3);
            Console.WriteLine(outputdouble);
            string outputstring = MaximumNumberCheck.MaximumStringValue("Apple","Peach","Banana");
            Console.WriteLine(outputstring);*/

            int[] intArray = { 112, 344, 432 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            int maxInt = generic.MaxMethod();
            Console.WriteLine(maxInt);
            double[] doubleArray = { 11.2, 34.4, 4.32 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            double maxDouble = Convert.ToDouble(generic.MaxMethod());
            Console.WriteLine(maxInt);
            string[] stringArray = { "Apple", "Peach","Banana" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            string maxString = Convert.ToString(generic.MaxMethod());
            Console.WriteLine(maxString);
        }
    }
}

