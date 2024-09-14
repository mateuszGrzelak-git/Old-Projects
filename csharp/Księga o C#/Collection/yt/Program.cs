using System;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Code

            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            System.Console.WriteLine("Count: {0}", aList.Count);

            System.Console.WriteLine("Capacity {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();

            aList2.AddRange(new object[] {
                "Mike","Sally","Egg"
            });

            aList.AddRange(aList2);

            aList2.Sort();
            aList2.Reverse();

            aList2.Insert(1,"Turkey");

            ArrayList range = aList2.GetRange(0,2);

            foreach (object o in range)
            {
                System.Console.WriteLine(o);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("aList2: ");
            foreach (var item in aList2)
            {
                System.Console.WriteLine(item);
            }

            aList2.RemoveAt(0);

            aList2.RemoveRange(0,2);
            

            #endregion 
            Console.ReadKey();
        }
    }
}
