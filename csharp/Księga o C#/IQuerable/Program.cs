using System;

namespace IQuerable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = {{1,2,3,4,5,6},{1,2,3,4,3,8}};
            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }


        }
    }
}
