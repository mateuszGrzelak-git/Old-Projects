using System;

namespace a5
{
    class Program
    {
        static int Liczenie(string d)
        {
            int a = 1;
            if(d.Length==1)
            {
            return d[0]-'0';
            }
            else
            {
                for (int i = 0; i < d.Length; i++)
                {
                    a*=d[i]-'0';
                }
                return Liczenie(a.ToString());
            }
        }
        static void Main(string[] args)
        {
            int d = 1;
            string a = Console.ReadLine();
            if (a.Length==1)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int x = 0; x < a.Length; x++)
                {
                    d*=a[x]-'0';
                }
            a = d.ToString();
            System.Console.WriteLine(Liczenie(a).ToString());
            }
            Console.ReadKey();
        }
    }
}
//https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec