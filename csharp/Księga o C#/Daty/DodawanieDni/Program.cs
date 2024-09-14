using System;

namespace DodawanieDni
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = new DateTime(2016,08,1,18,50,23,230);//DateTime.Now;
            DateTime answer = today.AddDays(36);
            System.Console.WriteLine("Today: {0:dddd}", answer);
            System.Console.WriteLine("36 days from today: {0:dddd}", answer);
        }
    }
}
