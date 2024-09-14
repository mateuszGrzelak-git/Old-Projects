using System;

namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int outsideInt = 20;
            SomeMethod(out outsideInt);

            System.Console.WriteLine(outsideInt);
            Console.ReadKey();
        }
         private static void SomeMethod(out int insideInt)
            {
                insideInt = 0;
                insideInt = insideInt + 10;
            }
    }
}
//przekazanie tylko referencji bez wartości