using System;
using System.Linq;
using System.Collections.Generic;

namespace j3
{
    class Program
    {
        static int[] Farmer(string data)
        {
            int ruch = 0;
            List<int> a = new List<int>();
            foreach (char item in data)
            {
                switch (item)
                {
                    case 'i':
                    ruch+=1;
                    break;
                    case 'd':
                    ruch-=1;
                    break;
                    case 's':
                    ruch = Convert.ToInt32(Math.Pow(ruch,2));
                    break;
                    case 'o':
                    a.Add(ruch);
                    break;
                }
            }
            return a.ToArray();
        }
        static void Main(string[] args)
        {
            Array a = Farmer("iiisdoso");
            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
/*
i increments the value (initially 0)
d decrements the value
s squares the value
o outputs the value into the return array
*/