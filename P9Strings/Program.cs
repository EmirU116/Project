using System;

namespace P9Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, What is your first name?: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("What is your last name?: ");
            string lastname = Console.ReadLine();
            
            Console.WriteLine("How old are you?: ");
            string age = Console.ReadLine();
            
            Console.WriteLine("Hello " + name + " " + lastname + ", you are " + age + " years old.");
        }
    }
}
