using System;
using System.Collections.Generic;

namespace Liczenie_przez_co_się_podzieli
{
    class Program
    {
        static List<int> a = new List<int>();
        static string odpowiedz = "";
        static void pierwiastek(int b)
        {
            int c = 0;
            if (b!=1)
            {
                for (int x = 2; x <= b; x++)
                {
                    if (b%x==0)
                    {
                        c=b/x;
                        a.Add(x);
                        pierwiastek(c);
                        break;
                    }
                }
            }
            //return a.Add(c);
        }
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
            d = ile/2.0;
            if (d%1!=0)
            {
                g=Math.Pow(c,d-0.5);
                if (g==1)
                {
                    odpowiedz+="pierwiastek z "+c.ToString()+" ";
                }
                else{
                odpowiedz+=g.ToString()+" pierwiastek z "+c.ToString()+" ";
                }
            }
            else
            {
                g = Math.Pow(c,d);
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
            try
            {
            int h=Convert.ToInt32(Console.ReadLine());
            pierwiastek(h);
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("Nie można wpisywać znaków");
                //System.Environment.Exit(0);
                
            }
            liczenie();
            System.Console.WriteLine(odpowiedz);
            Console.ReadKey();
        }
    }
}