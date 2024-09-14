using System;

namespace Bro_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\thello \bworld!");
            int x = 123;
            int y = 321;
            int z = x+y;
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);

            int number = 21;
            System.Console.WriteLine("You" + number);

            double height = 300.5;
            System.Console.WriteLine(height);

            bool alive = false;
            System.Console.WriteLine("Are you alive?" + alive); 

            char symbol = '@';
            System.Console.WriteLine(symbol);

            //const

            const double pi = 3.14;

            //pi = 3930940; tak nie można

            System.Console.WriteLine(pi);
            //type casting

            double a = 3.14;
            int b = Convert.ToInt32(a);
            int c = 123;
            double d = Convert.ToDouble(c);
            int e = 321;
            string f = Convert.ToString(e);
            string g = "$";
            char h = Convert.ToChar(g);
            string i = "true";
            bool j = Convert.ToBoolean(i);

            System.Console.WriteLine(a.GetType());
            System.Console.WriteLine(b);
            System.Console.WriteLine(d + 0.1);
            System.Console.WriteLine(f);
            System.Console.WriteLine(f.GetType());
            System.Console.WriteLine(g);
            System.Console.WriteLine(j);

            //input
            System.Console.Write("What's your name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine(name);

            Console.Write("Write your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(age);



            //Math

            int friends = 5;

            friends++;

            System.Console.WriteLine(friends);

            friends--;
            System.Console.WriteLine(friends);

            friends *= 2;

            System.Console.WriteLine(friends);

            friends-=1;
            friends = friends / 2;

            System.Console.WriteLine(friends);

            int remainder = friends % 3;
            System.Console.WriteLine(remainder);



            //Math class

            double basic = 3;
            double power = Math.Pow(basic, 2);
            System.Console.WriteLine(power);

            double square = Math.Sqrt(x);
            System.Console.WriteLine(square);

            double absolute = Math.Abs(x);
            System.Console.WriteLine(absolute);

            double decymalny = 3.14;
            double rounding = Math.Round(decymalny);
            System.Console.WriteLine(rounding);
            
            double ceil = Math.Ceiling(decymalny);
            System.Console.WriteLine(ceil);

            double floor = Math.Floor(decymalny);
            System.Console.WriteLine(floor);

            double max = Math.Max(x, y);
            System.Console.WriteLine(max);

            double min = Math.Min(x, y);
            System.Console.WriteLine(min);

            Console.ReadKey();
        }
    }
}
