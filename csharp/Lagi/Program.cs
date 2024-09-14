using System;
using System.IO;

namespace Mój_Kompilator
{
    class Program
    {

        static void Main(string[] args)
        {
            bool exit = true;
            bool limit = true;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Kolor kolor = new Kolor();
            kolor.Something();
                
            int numer = 1;
            string input = ""; 
            while(exit)
            {
                string c = "";
                string d = ""; 
                Console.Write(numer + " ");
                Console.SetCursorPosition(4, Console.GetCursorPosition().Top);
                while(exit)
                { 

                    ConsoleKeyInfo inputkey = Console.ReadKey();
                    Klawiatura k = new Klawiatura();
                    c = k.Przycisk(inputkey); 
                    if(inputkey.Key.Equals(ConsoleKey.Escape))
                    {
                        exit = false;
                    }
                    else if(inputkey.Key.Equals(ConsoleKey.Enter))
                    {
                        k.wiersz = 0;
                        break;
                    }
                    input += c;
                    d = "";
                    d = input;
                    c = "";
                    for (int i = 100; i < 300; i++)
                    {
                        
                    
                    if (!(Console.GetCursorPosition().Top.Equals(i)))
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