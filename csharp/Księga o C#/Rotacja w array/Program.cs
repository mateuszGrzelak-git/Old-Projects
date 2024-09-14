using System;

namespace Rotacja_w_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int shiftCount = 1;
            Rotate(ref array, shiftCount);
            Console.WriteLine(string.Join(", ", array));
            // Output: [10, 1, 2, 3, 4, 5, 6, 7, 8, 9]
            array = new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            shiftCount = 15;
            Rotate(ref array, shiftCount);
            Console.WriteLine(string.Join(", ", array));
            // Output: [6, 7, 8, 9, 10, 1, 2, 3, 4, 5]
            array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            shiftCount = -1;
            Rotate(ref array, shiftCount);
            Console.WriteLine(string.Join(", ", array));
            // Output: [2, 3, 4, 5, 6, 7, 8, 9, 10, 1]
            array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            shiftCount = -35;
            Rotate(ref array, shiftCount);
            Console.WriteLine(string.Join(", ", array));
            // Output: [6, 7, 8, 9, 10, 1, 2, 3, 4, 5]
            }
            private static void Rotate<T>(ref T[] array, int shiftCount)
            {
            T[] backupArray= new T[array.Length];
            for (int index = 0; index < array.Length; index++)
            {
            backupArray[(index + array.Length + shiftCount % array.Length) % array.Length] =
            array[index];
            }
            array = backupArray;
        }
    }
}