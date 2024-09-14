using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace a8
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> a = new List<int>();
            int liczba = 0;
            int[] solution = new int[input];
            for (int i = 0; i < input; i++)
            {
                a.Add(Convert.ToInt32(Console.ReadLine()));
            }
            a = a.OrderByDescending();
            for (int i = 0; i < a.Count(); i++)
            {
                if(a[liczba]*2>=a[i]&&liczba!=i)
                {
                    solution[liczba] = a[i];
                    liczba+=1;
                }
                else if (a[i]==a.Count-1)
                {
                    solution[liczba] = -1;
                    liczba +=1;
                }
                
            }
            foreach (int item in solution)
            {
                System.Console.WriteLine(item);
            }
            Console.ReadKey();

        }
        
        /*static async Task DoSomething()
        {
            var a = Enumerable.Range(1,100);
        }*/
        
    }

}