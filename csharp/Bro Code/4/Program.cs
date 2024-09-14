using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ford = {"Mustang", "F-150", "Explorer"};
            string[] chevy = {"Corvette", "Canaro", "Silverado"};
            string[] toyota = {"Corolla", "Canary", "Rav4"};

            string[,] parkingLot = {{"Mustang", "F-150", "Explorer"},{"Corvette", "Canaro", "Silverado"},{"Corolla", "Canary", "Rav4"}};

            parkingLot[0, 2] = "Fusion";
            parkingLot[2,0] = "Tacoma";
/*
            foreach (string car in parkingLot)
            {
                System.Console.WriteLine(car);
            }
*/
            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.WriteLine(parkingLot[i,j] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
