using System;

namespace In
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            ExampleIn(in value);
            var couldParse = int.TryParse("68", out int parsedValue);//liczba lub false

            void ExampleIn(in int valuea)
            {
                valuea.ToString();
            }

           System.Console.WriteLine(value);
        }
    }
}
