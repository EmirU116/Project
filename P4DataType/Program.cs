using System;

namespace P4DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputString;
            float decimalValue;
            bool isAwesome;
            byte someByte;

            decimalValue = 0.3F;
            isAwesome = true;
            outputString = "Hello World";
            someByte = 0xa7;
            
            Console.WriteLine(outputString);
            Console.WriteLine(decimalValue);
            Console.WriteLine(isAwesome);
            Console.WriteLine(someByte);
        }
    }
}
