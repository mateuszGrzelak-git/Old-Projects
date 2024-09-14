using System;
using System.Linq;
using System.Collections.Generic;

namespace Link
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            foreach (var a in list)
            {
              
            }

            Func<int,int> function = a => { return a; };
            Action functi = () => {System.Console.WriteLine("Hello");};
            Action functio = () => System.Console.WriteLine("Hello");
            functi();
            functi.Invoke();

            var listOfInts = new List<int>
            {
                3,7,8,11,2,1
            };
            var listOfStrings = new List<string>
            {
                "Ala",
                "Ma",
                "Kota",
                "I",
                "",
                "Samochód"
            };
            var listOfUsers = new List<User>
            {
                new User
                {
                    firstName = "Patryk",
                    LastName = "Mikulski",
                    Email = "Csharpjestfajny@programowanie.też"
                },
                new User
                {
                    firstName = "Maciek",
                    LastName = "Fajny",
                    Email = "Csharpjestfajny@programowanie.też"
                },
                new User
                {
                    firstName = "Piotr",
                    Email = "inny@mail.też"
                },
                null
            };

            listOfInts.Select(x => x+2);
            listOfInts.Select(x => {return x+2;});
            listOfInts.Select(x => x+2).ToList();
            listOfUsers.Select(x => x.firstName);
            listOfUsers.Select(x => new 
            {
                first = x.firstName,
                second = x.LastName
            }).Select(x => x.second);

            var listOfLastNameUsers = listOfUsers.Where(x => x != null /*żeby nie było null*/&& !string.IsNullOrEmpty(x.LastName)).ToList();
            listOfLastNameUsers.ForEach(x =>
            {
                System.Console.WriteLine(x.firstName + " " + x.LastName);
            });
            var listOfLastNameUser = listOfUsers.Where(x => x != null /*żeby nie było null*/&& x.LastName=="Bla").First();//tak nie można bo first jest null
            var listOfLastNameUse = listOfUsers.Where(x => x != null /*żeby nie było null*/&& x.LastName=="Bla").FirstOrDefault();
            if (listOfLastNameUse!=null)
            {
                System.Console.WriteLine(listOfLastNameUse.firstName + " " + listOfLastNameUse.LastName);
            }
            var listOfLastNameUs = listOfUsers.FirstOrDefault(x => x != null /*żeby nie było null*/&& x.firstName=="Piotr");
            var listOfLastNameU = listOfUsers.Where(x => x != null /*żeby nie było null*/&& x.Email=="Csharpjestfajny@programowanie.też").Skip(1).FirstOrDefault();
            var tekstySortowane = listOfStrings.OrderBy(x=>x).ToList();
            var tekstySortowan = listOfStrings.OrderByDescending(x=>x).ToList();
            var suma = listOfInts.Sum(x=>x);
            /*var groups = listOfUsers.GroupBy(x=>x.Email).ToList().ForEach(x=>
            {
                System.Console.WriteLine(x.Key);
            });*/ //nie działa bo null
            var groups = listOfUsers.Where(x=>x != null).GroupBy(x=>x.Email).ToList().ForEach(x=>
            {
                System.Console.WriteLine(x.Key);

                x.ToList().ForEach(y => 
                {
                    System.Console.WriteLine(y.firstName);
                });
            });
        }
    }
}
//https://youtu.be/Dbnl6NNiVik?t=2319
//linq 2 trzeba