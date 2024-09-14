using System;

namespace class_bo_nie_można
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages a = new Messages();
            a.Hello();

            Console.ReadKey();
        }
    }
    class Messages
    {
        public void Hello()
        {
            System.Console.WriteLine("Hello");
        }
        public void Waiting()
        {
            System.Console.WriteLine("Wait");
        }
        public void Bye()
        {
            System.Console.WriteLine("Bye");
        }
    }
}
