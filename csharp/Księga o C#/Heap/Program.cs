using System;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 95;
            int score2 = score;
            System.Console.WriteLine("score = {0}, score2 = {1}", score, score2);

            Report report = new Report()
            {
                Title = "First Report",
                Desc = "This is the first report",
                Pages = 11
            };

            Report report2 = report;

            report2.Pages = 999;

            System.Console.WriteLine(report.Display());
            System.Console.WriteLine(report2.Display());

            ProcessIt(score,report);
            System.Console.WriteLine(score);
            System.Console.WriteLine(report.Pages);

            Console.ReadKey();
        }

        static void ProcessIt(int s,Report r)
        {
            s = 1111;
            r.Pages = 11111;
        }
        class Report
        {
            public string Title{ get; set; }
            public string Desc{get;set;}
            public int Pages{get;set;}

            public string Display()
            {
                return String.Format("{0}:{1}, pp. {2}", Title, Desc, Pages);
            }
        }
    }
}
//Report2 korzysta z tego samego źródła co report
//żeby była kopia źródła musisz zmienić na struct
// struct jest w stack a nie w heap
//zmieniają się tylko pages bez struct