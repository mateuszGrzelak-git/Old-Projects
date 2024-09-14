using System;
using System.Collections;
using System.Collections.Generic;

namespace dokumentacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Listy listy = new Listy();
            listy.Letter();

            System.Console.WriteLine();

            Dictionary dictionary = new Dictionary();
            dictionary.slownik();

            System.Console.WriteLine();

            AQueue queue = new AQueue();
            queue.kolejka();

            System.Console.WriteLine();

            new Collections().kolekcje();

            System.Console.WriteLine();

            new Wlasne().IterateThroughList();

            //List<int> list = new List<int>();

            Console.ReadKey();
        }
    }
}
