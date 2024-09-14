using System;
using System.Collections;
using System.Linq;

namespace dokumentacja
{
    class AQueue
    {
        public void kolejka()
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("1 in queue : {0}", queue.Contains(1));

            Console.WriteLine("Remove 1 : {0}", queue.Dequeue());

            Console.WriteLine("Peek 1 : {0}", queue.Peek());

            object[] numArray = queue.ToArray();

            Console.WriteLine(string.Join(", ",numArray));

            foreach(object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }
        }
    }
}