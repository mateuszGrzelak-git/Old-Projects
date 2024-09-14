using System;

namespace c_9
{
    class Program
    {
        static void Main(string[] args)
        {
System.Console.WriteLine(args);           
        }
        Records.Mammal mammal = new("", "");
        static void Do(Records.Mammal mammal)
        {
        }
        Do(new("", ""));
        static Records.Mammal GetMammal()
        {
            return new("", "");
        }
    }
}