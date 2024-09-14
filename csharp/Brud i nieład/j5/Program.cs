using System;
using System.Linq;
using System.Collections.Generic;

namespace j5
{
    class Program
    {
        static char[] setValues(string message, ref Dictionary<int,char[]> h)
        {
            int a = h.Count;
            string message1;
            if (message.Length==0)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < a; i++)
                {
                    
                }
                setValues(message1,ref h);
            }
        }
        static string DeNico(string key, string message) 
        {
            Dictionary<int,char[]> h = new Dictionary<int, char[]>();
            int liczba = key.Length;
            char[] wartosci = new char[]{};
            int a = Convert.ToInt32(Math.Floor((decimal)(message.Length/liczba)));
            //int[,] kod = new int[liczba,a];
            for (int i = 0; i < liczba; i++)
            {
                h.Add(Convert.ToInt32(key[i]),new char[]{});
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("kabpc","jidejidji");
        }
    }
}
//https://www.codewars.com/kata/596f610441372ee0de00006e/train/csharp