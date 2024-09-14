using System;
using System.Collections.Generic;

namespace _4
{
    class Program
    {
        static List<int> a = new List<int>();
        static string odpowiedz = "";
        static void liczenie()
        {
            int c = 0;
            int ile = 0;
            double d = 0;
            double g = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (c==0)
                {
                    c=a[0];
                    ile=1;
                }
                else
                {
                    if (c==a[i])
                    {
                        ile+=1;
                    }
                }
            }
            d = ile/2;
            if (d%1!=0)
            {
                g=c*(d-0.5);
                odpowiedz+=g.ToString()+" pierwiastek z "+c.ToString()+" ";
            }
            else
            {
                g = c*d;
                odpowiedz+=g.ToString()+" ";
            }
            for (; ile > 0; ile--)
            {
            a.Remove(c);   
            }
            if (a.Count!=0)
            {
                liczenie();
            }
        }
        
        static void Main(string[] args)
        {
           liczenie(); 
        }
    }
}
