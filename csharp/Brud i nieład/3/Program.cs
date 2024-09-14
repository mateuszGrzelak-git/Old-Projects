using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());
            int c;
            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here
            foreach(int a in coffee.Values)
            {
                c = a*discount/100;
                System.Console.WriteLine(coffee.ContainsValue(a), c);
            }
            coffee.TryGetValue
        }
    }
}
