using System;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int outsideInt = 20;
            SomeMethod(ref outsideInt);

            System.Console.WriteLine(outsideInt);
            Console.ReadKey();
        }
         private static void SomeMethod(ref int insideInt)
            {
                insideInt = insideInt + 10;
            }
    }
}
//ref = przekazanie wartości (i referencji)
// dodanie do intów ref
// modyfikacja kopii i referencji