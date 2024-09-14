using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {

            // string toJestString = "aa";
            // toJestString.ToUpper();

            // //błąd
            // /*object toJestObject = "aa";
            // toJestObject.ToUpper();*/

            // dynamic toJestDynamic = "aa";
            // toJestDynamic.ToUpper();//nie ma żadnych podpowiedzi ani błędu
            // //kompilacja w czasie rzeczywistym, zastabawia się dopiero po kompilacji co to

            // int myInt = 1 + 3;
            // var mvar = 1+3;
            // dynamic dyn = 1+3;
            // object obj = 1+3;

            // System.Console.WriteLine(myInt.GetType());
            // System.Console.WriteLine(mvar.GetType());
            // System.Console.WriteLine(dyn.GetType());
            // System.Console.WriteLine(obj.GetType());

            dynamic dyna;
            int a = 20;

            dyna = a;
            
            string b = "To jest Dynamic !!";

            dyna = b;

            DateTime dt = new DateTime(2020,5,1);

            dyna = dt;

            Console.ReadKey();
        }
    }
}
