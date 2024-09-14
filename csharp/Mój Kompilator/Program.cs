using System;
using System.IO;

namespace Mój_Kompilator
{
    class Program
    {

        static void Main(string[] args)
        {
            bool pierwszy = true;
            bool check = true;
            bool sto = false;
            bool exit = true;
            bool limit = true;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Kolor kolor = new Kolor();
            kolor.Something();
            int numer = 1;
            string input = "";
            while(exit)
            {
                string c = "";
                string d = "";
                if (pierwszy)
                {
                    Console.SetCursorPosition(0,0);
                    Console.Write(numer + " ");
                    Console.SetCursorPosition(4,0);
                    pierwszy = false;
                }
                else
                {
                Console.Write(numer + " ");
                }
                    if (check)
                {
                    Console.SetCursorPosition(4,Console.GetCursorPosition().Top);
                } 
                while(exit)
                { 

                    //klawisze
                    ConsoleKeyInfo inputkey = Console.ReadKey();
                    Klawiatura k = new Klawiatura();
                    c = k.Przycisk(inputkey);
                    exit = k.Exit(inputkey); 
                    if(inputkey.Key.Equals(ConsoleKey.Enter))
                    {
                        k.wiersz = 0;
                        break;
                    }


                    input += c;
                    d = "";
                    d = input;
                    c = "";
                    if (Console.GetCursorPosition().Top.Equals(99))
                    {
                        Console.SetCursorPosition(5,Console.GetCursorPosition().Top);
                        sto = true;
                        check=false;
                    }
                    else if(Console.GetCursorPosition().Top.Equals(98))
                    {
                        Console.SetCursorPosition(4,Console.GetCursorPosition().Top);
                        sto=false;
                        check=false;
                    }
                    if (!sto)
                    {
                        if (Console.GetCursorPosition().Left.Equals(1) || Console.GetCursorPosition().Left.Equals(2) || Console.GetCursorPosition().Left.Equals(3))
                        {
                            Console.SetCursorPosition(4, Console.GetCursorPosition().Top);
                        }
                    }
                    else
                    {
                        if (Console.GetCursorPosition().Left.Equals(1) || Console.GetCursorPosition().Left.Equals(2) || Console.GetCursorPosition().Left.Equals(3) || Console.GetCursorPosition().Left.Equals(4))
                        {
                            Console.SetCursorPosition(5, Console.GetCursorPosition().Top);    
                        }
                    }
                }
                if (Console.GetCursorPosition().Top.Equals((Console.LargestWindowHeight*3 + 47)))
                {
                    Console.SetCursorPosition(Console.GetCursorPosition().Top,Console.GetCursorPosition().Left);
                    limit = false;
                }
                else if(limit)
                {
                input += "\n";
                Console.WriteLine();
                //Console.WriteLine(input);
                numer++;
                }
            }
            if (!exit)
            {
                using (StreamWriter sw = File.CreateText("ukryty.txt"))
                    {
                        sw.WriteLine(input);
                    }

            }
        }
    }
}