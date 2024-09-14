using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            
            int num = random.Next(1, 7);
            double ran = random.NextDouble();
            
            System.Console.WriteLine(num);
            System.Console.WriteLine(ran);



            //string


            string fullName = "Bro Code";

            fullName = fullName.ToUpper();
            System.Console.WriteLine(fullName);

            fullName = fullName.ToLower();
            System.Console.WriteLine(fullName);

            string phoneNumber = "123-456-7890";
            phoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine(phoneNumber);

            string username = fullName.Insert(0,"Mr. ");
            System.Console.WriteLine(username);

            System.Console.WriteLine(fullName.Length);

            string firstName = fullName.Substring(0,3);
            System.Console.WriteLine(firstName);

            string lastName = fullName.Substring(4,4);
            System.Console.WriteLine(lastName);

            //if statements
            System.Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 18)
            {
                System.Console.WriteLine("You are above 18!");
            }
            else
            {
                System.Console.WriteLine("You are under 18!");
            }


            //arrays

            string[] cars = new string[3];
            string[] curly = {"BMW", "Mustang", "Tesla"};
            System.Console.WriteLine(curly[0]);
            System.Console.WriteLine(curly[1]);
            System.Console.WriteLine(curly[2]);

            cars[0] = "Tesla";
            cars[1] = "Audi";
            cars[2] = "Car";

            //foreach

            foreach(string car in cars)
            {
                Console.Write(car + " ");
            }

            //methods

            string name = "Person"; 

            static void sing(string name)
            {
                Console.WriteLine("Happy " + name);
            }

            sing(name); 

            Console.ReadKey();
        }
    }
}
