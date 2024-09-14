using System;
using System.Collections;

namespace dokumentacja
{
    class Listy
    {
        public void Letter()
        {
            ArrayList aList = new ArrayList();

            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine("Count: {0}", aList.Count);

			ArrayList aList2 = new ArrayList();

            aList2.AddRange(new object[] {"Mike","Sally","Egg"});

            aList.AddRange(aList2);

            aList2.Sort();
            aList2.Reverse();

            aList2.Insert(1, "Turkey");

            ArrayList range = aList2.GetRange(0,2);

            foreach(object o in aList2)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Turkey Index: {0}",aList2.IndexOf("Turkey",0));

            string[] myArray = (string[])
            aList2.ToArray(typeof(string));

            string[] customers = {"Bob", "Sally", "Sue"};

            ArrayList custArrayList = new ArrayList();

            custArrayList.AddRange(customers);

            foreach(string s in custArrayList)
            {
                Console.WriteLine(s);
            }
        }
    }
}