using System;

namespace timer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create datetime
DateTime dt = new DateTime(2016,08,01,18,50,23,230);
var t = String.Format("{0:t}", dt); // "6:50 PM" ShortTime
var d = String.Format("{0:d}", dt); // "8/1/2016" ShortDate
var T = String.Format("{0:T}", dt); // "6:50:23 PM" LongTime
var D = String.Format("{0:D}", dt); // "Monday, August 1, 2016" LongDate
var f = String.Format("{0:f}", dt); // "Monday, August 1, 2016 6:50 PM" LongDate+ShortTime
var F = String.Format("{0:F}", dt); // "Monday, August 1, 2016 6:50:23 PM" FullDateTime
var g = String.Format("{0:g}", dt); // "8/1/2016 6:50 PM" ShortDate+ShortTime
var G = String.Format("{0:G}", dt); // "8/1/2016 6:50:23 PM" ShortDate+LongTime
var m = String.Format("{0:m}", dt); // "August 1" MonthDay
var y = String.Format("{0:y}", dt); // "August 2016" YearMonth
var r = String.Format("{0:r}", dt); // "SMon, 01 Aug 2016 18:50:23 GMT" RFC1123
var s = String.Format("{0:s}", dt); // "2016-08-01T18:50:23" SortableDateTime
var u = String.Format("{0:u}", dt); // "2016-08-01 18:50:23Z"


var year = String.Format("{0:y yy yyy yyyy}", dt); // "16 16 2016 2016" year
var month = String.Format("{0:M MM MMM MMMM}", dt); // "8 08 Aug August" month
var day = String.Format("{0:d dd ddd dddd}", dt); // "1 01 Mon Monday" day
var hour = String.Format("{0:h hh H HH}", dt); // "6 06 18 18" hour 12/24
var minute = String.Format("{0:m mm}", dt); // "50 50" minute
var secound = String.Format("{0:s ss}", dt); // "23 23" second
var fraction = String.Format("{0:f ff fff ffff}", dt); // "2 23 230 2300" sec.fraction
var fraction2 = String.Format("{0:F FF FFF FFFF}", dt); // "2 23 23 23" without zeroes
var period = String.Format("{0:t tt}", dt); // "P PM" A.M. or P.M.
var zone = String.Format("{0:z zz zzz}", dt); // "+0 +00 +00:00" time zone

System.Console.WriteLine(u);

            Console.ReadKey();
        }
    }
}
