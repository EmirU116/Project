using System;
using System.Diagnostics;

namespace _10Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?: ");
            bool isChild = true;
            bool isTeenager = true;
            bool isAdult = true;
            
            int age = Convert.ToInt16(Console.ReadLine());
            if (isChild && (age < 12))
            {
                Console.WriteLine("You are a Child: True ");
                Console.WriteLine("You are a Teenager: False");
                Console.WriteLine("You are a Adult: False ");
            }
            else if (isTeenager && (age < 19))
            {
                Console.WriteLine("You are a Child: False ");
                Console.WriteLine("You are a Teenager: True");
                Console.WriteLine("You are a Adult: False "); 
            } 
            else if (isAdult && (age >= 20))
            {
                Console.WriteLine("You are a Child: False ");
                Console.WriteLine("You are a Teenager: False");
                Console.WriteLine("You are a Adult: True "); 
            } 

        }
    }
}
