using System;

namespace DodawanieGodzin
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] hours = {.08333, .16667, .25, .3333, .5, .66667,1,2,29,30,31,90,365};
            DateTime dateValue = new DateTime(2009,3,1,12,0,0);
            foreach(double hour in hours)
            {
                System.Console.WriteLine("{0} + {1} hour(s) = {2}", dateValue, hour, dateValue.AddHours(hour));
                
            }
        }
    }
}
