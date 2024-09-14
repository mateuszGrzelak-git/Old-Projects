using System;

namespace Ważne_nie_trzeba_if
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature = 20;
            string message;
            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside";
            System.Console.WriteLine(message);
        }
    }
}
