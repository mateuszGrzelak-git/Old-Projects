using System;

namespace Mój_Kompilator
{
    class Klawiatura
    {
        public int wiersz = 0;
        public int miejsce = 0;
        public string c;
        public string Przycisk(ConsoleKeyInfo inputkey){
            if(inputkey.Key.Equals(ConsoleKey.Backspace))
                    {
                        if (Console.GetCursorPosition().Left.Equals(3) || Console.GetCursorPosition().Left.Equals(2) || Console.GetCursorPosition().Left.Equals(1))
                        {
                            Console.SetCursorPosition(4,Console.GetCursorPosition().Top);
                        }
                        else
                        {
                            int o = Console.GetCursorPosition().Left;
                            //width change to 4
                            Console.Write(" ");
                            Console.SetCursorPosition(o,Console.GetCursorPosition().Top);
                        }
                        
                    }
                    switch (inputkey.Key)
                    {
                        case ConsoleKey.A:
                        c = "a";
                        break;
                        case ConsoleKey.B:
                        c = "b";
                        break;
                        case ConsoleKey.C:
                        c = "c";
                        break;
                        case ConsoleKey.D:
                        c = "d";
                        break;
                        case ConsoleKey.E:
                        c = "e";
                        break;
                        case ConsoleKey.F:
                        c = "f";
                        break;
                        case ConsoleKey.G:
                        c = "g";
                        break;
                        case ConsoleKey.H:
                        c = "h";
                        break;
                        case ConsoleKey.I:
                        c = "i";
                        break;
                        case ConsoleKey.J:
                        c = "j";
                        break;
                        case ConsoleKey.K:
                        c = "k";
                        break;
                        case ConsoleKey.L:
                        c = "l";
                        break;
                        case ConsoleKey.M:
                        c = "m";
                        break;
                        case ConsoleKey.N:
                        c = "n";
                        break;
                        case ConsoleKey.O:
                        c = "o";
                        break;
                        case ConsoleKey.P:
                        c = "p";
                        break;
                        case ConsoleKey.R:
                        c = "r";
                        break;
                        case ConsoleKey.S:
                        c = "s";
                        break;
                        case ConsoleKey.T:
                        c = "t";
                        break;
                        case ConsoleKey.U:
                        c = "u";
                        break;
                        case ConsoleKey.W:
                        c = "w";
                        break;
                        case ConsoleKey.X:
                        c = "x";
                        break;
                        case ConsoleKey.Y:
                        c = "y";
                        break;
                        case ConsoleKey.Z:
                        c = "z";
                        break;
                        case ConsoleKey.Spacebar:
                        c = " ";
                        break;
                        case ConsoleKey.UpArrow:
                            miejsce-=2;
                            try
                            {
                            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop -1);
                            
                            }
                            catch(ArgumentOutOfRangeException)
                            {
                                Console.SetCursorPosition(4,0);
                            }
                            wiersz = 0;
                            break;
                        case ConsoleKey.LeftArrow:
                            try
                            {
                            Console.SetCursorPosition(Console.CursorLeft -2,Console.CursorTop);
                            }
                            catch(ArgumentOutOfRangeException)
                            {
                                Console.SetCursorPosition(4,0);
                            }
                            wiersz--;
                            break;
                        case ConsoleKey.DownArrow:
                            miejsce+=2;
                            try
                            {
                            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop +1);
                            }
                            catch(ArgumentOutOfRangeException)
                            {
                                Console.SetCursorPosition(4,0);
                            }
                            break;
                        case ConsoleKey.Oem4:
                            Console.Write("]");
                            break;
                        case ConsoleKey.D9:
                            Console.Write(")");
                            break;
                        case ConsoleKey.Enter:
                            miejsce += wiersz + 2;
                             break;
                        /*case ConsoleKey.RightArrow:

                            break;
                        */
                    }
                    //Może się przypadkiem zerować
                    wiersz++;
                    return c; 
        }
        public bool Exit(ConsoleKeyInfo escape)
        {
            if (escape.Key.Equals(ConsoleKey.Escape))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}