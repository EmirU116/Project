using System;
using System.Globalization;

namespace P5Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            string numberString = number.ToString();
            Console.WriteLine(numberString);

            numberString = 56.3.ToString();
            double d = Convert.ToDouble(numberString);
            number = (int) d;
            Console.WriteLine(number);
        }
    }
}