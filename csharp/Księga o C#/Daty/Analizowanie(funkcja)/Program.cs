using System;

namespace Analizowanie_funkcja_
{
    class Program
    {
        static void Main(string[] args)
        {
            //normalnie
                /*var dateTime = DateTime.Parse("14:23  22 Jul 2016");
                System.Console.WriteLine(dateTime.ToString());*/

            //Próba analizy
            // Converts the specified string representation of a date and time to its DateTime equivalent and
            //returns a value that indicates whether the conversion succeeded
            string[] dateTimeStrings = new []{
            "14:23 22 Jul 2016",
            "99:23 2x Jul 2016",
            "22/7/2016 14:23:00"
            };
            foreach(var dateTimeString in dateTimeStrings){
            DateTime dateTime;
            
            bool wasParsed = DateTime.TryParse(dateTimeString, out dateTime);
            
            string result = dateTimeString +
            (wasParsed? $" was parsed to {dateTime}"
            : " can't be parsed to DateTime");
            
            Console.WriteLine(result);
            }
        }
    }
}
