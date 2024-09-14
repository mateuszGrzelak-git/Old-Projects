using System;

namespace Mój_Kompilator
{
    class Kolor
    {
        public int dalej = 0;
        public void Something()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        while(true)
                {
                    
                    Console.Write(" ");
                    if (Console.GetCursorPosition().Left.Equals(3 + dalej))
                    {
                        if(!Console.GetCursorPosition().Top.Equals(100))
                        Console.Write("│");
                        else
                        {
                            System.Console.Write("\\");
                            dalej++;
                        }     
                    }
                    else if (Console.GetCursorPosition().Top.Equals(Console.LargestWindowHeight*3 + 47) && Console.GetCursorPosition().Left.Equals(Console.LargestWindowWidth-1))
                    {
                        Console.SetCursorPosition(0,0);
                        break;
                    }
                }
        }
    }
}