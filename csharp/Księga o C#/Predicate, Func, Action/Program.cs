using System;

namespace Predicate__Func__Action
{
    class Program
    {
        delegate double CalculateAreaPointer(double r);
        static CalculateAreaPointer cpointer = CalculateArea;
        static void Main(string[] args)
        {
            double area = cpointer.Invoke(20);
        }
        static double CalculateArea(double r)
        {
            return Math.PI*r*r;
        }
    }
}
