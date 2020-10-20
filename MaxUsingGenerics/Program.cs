using System;
using System.Collections.Generic;

namespace MaxUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            
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

