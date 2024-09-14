using System;
using System.Collections.Generic;

namespace dokumentacja
{
    class Collections
    {
        public void kolekcje()
        {
            var salmons = new List<string>();

            var salmons2 = new List<string>{"chinook", "coho", "pink", "sockeye"};

            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            foreach(var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }

            Console.WriteLine();
            foreach(var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }

            Console.WriteLine();

            var numbers = new List<int>{1,2,3,4,5,6,7};

            for(var index = numbers.Count - 1;index>=0;index--)
            {
                if(numbers[index]%2==1)
                {
                    numbers.RemoveAt(index);
                }
            }

            numbers.ForEach(number=>Console.WriteLine(number + " "));
        }
    }
}