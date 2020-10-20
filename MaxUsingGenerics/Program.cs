using System;
using System.Collections.Generic;

namespace MaxUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            double outputdouble = MaximumNumberCheck.MaximumDoubleNumber(11.1, 22.2, 33.3);
            Console.WriteLine(outputdouble);
            string outputstring = MaximumNumberCheck.MaximumStringValue("Apple","Peach","Banana");
            Console.WriteLine(outputstring);

        }
    }
}

