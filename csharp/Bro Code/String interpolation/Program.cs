using System;

namespace String_interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName  ="Bro";
            string lastName = "Code";
            int age = 55;

            System.Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            System.Console.WriteLine("You're " + age + " years old.");

            System.Console.WriteLine($"Hello {firstName} {lastName}.");
            System.Console.WriteLine($"You're {age,10} years old.");
        }
    }
}
