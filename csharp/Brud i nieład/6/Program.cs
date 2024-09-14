using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a="39";
            //byte f = Convert.ToInt32(a);
            System.Console.WriteLine(Convert.ToInt32(a[0]));//ascii
            System.Console.WriteLine(Convert.ToInt32("3"));
            int b = Convert.ToInt32(a[0])*Convert.ToInt32(a[1]);
            System.Console.WriteLine(b);
            int bar = a[0] - '0';
            int h = a[0];
            System.Console.WriteLine(bar);
            System.Console.WriteLine(h);
            /*for (int x = 0; x < a.Length; x++)
            {
                
            }*/
        }
    }
}
