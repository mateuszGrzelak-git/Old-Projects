using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ewewe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*foreach (var coffee in new CoffeeCollection()) {
                Console.WriteLine(coffee);
                }
                }
                public class CoffeeCollection : IEnumerable {
                private CoffeeEnumerator enumerator;
                public CoffeeCollection() {
                enumerator = new CoffeeEnumerator();
                }
                public IEnumerator GetEnumerator() {
                return enumerator;
                }
                public class CoffeeEnumerator : IEnumerator {
                string[] beverages = new string[3] { "espresso", "macchiato", "latte" };
                int currentIndex = -1;
                public object Current {
                get {
                return beverages[currentIndex];
                }
                }
                public bool MoveNext() {
                currentIndex++;
                if (currentIndex < beverages.Length) {
                return true;
                }
                return false;
                }
                public void Reset() {
                currentIndex = 0;
        }
    }*/




    #region List
    List<int> myList = new List<int>();
    myList.Add(100);
    myList.Add(200);
    myList.Add(300);
    myList.Add(400);
    myList.Add(1000);
    myList.Add(1001);
    myList.Add(1002);
    #endregion
    /*IEnumerable<int> ienumerable = myList.AsEnumerable();/*

    foreach (var item in ienumerable)
    {
        System.Console.WriteLine(item);
    }*/

    IEnumerator<int> ienumerator = myList.GetEnumerator();

    /*while (ienumerator.MoveNext())
    {
        System.Console.WriteLine(ienumerator.Current.ToString());
    }*/

    //ienumerable jest jak ienumerator tylko prostsze 

    LoopTo1000(ienumerator);

    Console.ReadKey();
}
    static void LoopTo1000(IEnumerator<int> e)
    {
        while (e.MoveNext())
        {
            System.Console.WriteLine(e.Current.ToString());
            if (e.Current>999)
            {
                LoopAbove1000(e);
            }
        }
    }

    static void LoopAbove1000(IEnumerator<int> e)
    {
        while (e.MoveNext())
        {
            System.Console.WriteLine(e.Current.ToString());
        }
    }
    //zobacz jak się wykonało
    //ienumerable nie wie gdzie ma kursor
    }}