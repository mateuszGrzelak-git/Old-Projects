using System;
using System.Collections.Generic;

namespace Yield
{
    class Program
    {
        static List<int> myList = new List<int>();
        static void Main(string[] args)
        {
            FillList();
            foreach (var item in /*Filter()*/Total())
            {
                System.Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static void FillList()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
        }
        static IEnumerable<int> Filter()
        {
            //List<int> tmp = new List<int>();
            foreach (var item in myList)
            {
                if (item>3)
                {
                    //tmp.Add(item);
                    yield return item;
                }
            }
            //return tmp;

        }
        static IEnumerable<int> Total()
        {
            int totalNumber = 0;
            foreach (var item in myList)
            {
                totalNumber += item;
                yield return (totalNumber);
                //zachowanie stanu poprzedniego
            }
        }
    }
}
/*yield:
- szybkość
- yield nie zwraca wartości od razu tylko zapamiętuje gdzie skończył(index)
- wrzuca od razu do foreach(debug)
- modyfikacje na oryginalnej liście
*/