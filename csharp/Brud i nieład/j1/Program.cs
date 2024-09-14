using System;
using System.Linq;
using System.Collections.Generic;

namespace j1
{
    class Program
    {
        public static int? chooseBestSum(int t, int k, List<int> ls) 
        {
            
            List<int> a = ls;
            a = a.OrderByDescending(x=>x).ToList<int>();
            int meters = 0;
            while(true)
            {
                if(meters+a.Last()>k)
                {
                    break;
                }
                else
                {
                meters += a.Last();
                a = a.SkipLast(a.Count).ToList<int>();
            }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
