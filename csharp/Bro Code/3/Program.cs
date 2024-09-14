using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;

            Console.WriteLine("Enter in number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x,y);
            Console.WriteLine(result);
double z = 3;
            double total = Multiply(x,y,z);

            System.Console.WriteLine(total);


            double suma = CheckOut(3.99,5.75,15);
            System.Console.WriteLine(suma);


            Console.ReadKey();
        }

        static double Multiply(double x, double y)
        {
            double z = x*y;
            return z;
        }
        static double Multiply(double x, double y, double c)
        {
            double z = x*y*c;
            return z;
        }
        static double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
              total = total + price;  
            }
            return total;
        }
    }
}
