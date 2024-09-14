using System;
using System.Collections.Generic;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string ziomek = "text";
            int ziomal = 2;
            float ZiomalZKropką;
            decimal Precyzyzjny;
            double PoProstu;
            bool Prawdziwosc;
            string ByWyswietlic = ziomal.ToString();
            var War = 4; //od razu int
            var suma = ziomal + 2;
            suma = suma + 1;
            string odGoscia;

            Console.WriteLine(suma);
            Console.WriteLine(ziomek);
            Console.WriteLine(ByWyswietlic);
            odGoscia = Console.ReadLine();
            Console.WriteLine(odGoscia);
            //za dużo

            int liczba = 3;
            if (liczba<4)
            {
                Console.WriteLine("Ok");
            }

            string c;
            c = Console.ReadLine();
            if (c=="Pov")
            {
                Console.WriteLine("Wow");
            }
            else if (c=="jawiem"){
                Console.WriteLine("O nie!");
            }
            else
            {
                Console.WriteLine("BOO");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("5 razy");
            }

            var lista = new List<int>();

            lista.Add(3);

            System.Console.WriteLine(lista[0]);

            static int funkcja(int odFunkcji)
            {
                
                return odFunkcji+1;
            }            
            static string cotam (params string[] strings){//nieskonczenie wiele dla strings
                return "fafafasfas";
            }
            int d = funkcja(3);
            System.Console.WriteLine(d);
            string p = cotam ("adsdasd");
           /* while (true){
                Console.WriteLine("To w c#");
            }*/

        }
    }
}
