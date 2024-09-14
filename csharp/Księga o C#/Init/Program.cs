using System;

namespace Init
{
    class Przyklad
    {
        public string MyProperty { get; init; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Przyklad przyklad = new Przyklad();
            //przyklad.MyProperty = "Yasuo";
            var dobrze = new Przyklad
            {
                MyProperty = "Nick Chapsa"
            };
            System.Console.WriteLine(dobrze.MyProperty);
            Console.ReadKey();
        }
    }
}
