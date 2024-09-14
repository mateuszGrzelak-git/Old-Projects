using System;
using System.Threading;

namespace Alarm
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Wpisz kiedy zaczyna się lekcja(minuty): ");
            int stop = Convert.ToInt32(Console.ReadLine());
            while(true)
            {
            int minuty = DateTime.Now.Minute;
            if (minuty==stop)
            {
                //wpisz lokalizację alarmu
                System.Diagnostics.Process.Start("");
                break;
            }
            Thread.Sleep(60000);
            System.Console.WriteLine("Minęła 1 minuta");
            }
        }
    }
}
