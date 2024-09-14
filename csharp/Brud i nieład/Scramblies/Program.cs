using System;
using System.Linq;
using System.Collections.Generic;
namespace j4
{
    class Program
    {
        static bool Scramble(string str1, string str2) 
        {
            char[] text1 = str1.OrderBy(x=>x).ToArray();
            char[] text2 = str2.OrderBy(x=>x).ToArray();
            int liczba = text1.Length;
            for (int i = 0; i <= liczba; i++)
            {
                if (text2.Count()==0)
                {
                    return true;
                }
                else if (text1.Count()==0||!text1.Contains(text2[0]))
                {
                    return false;
                }
                else if (text1[0]==text2[0])
                {
                    text1 = text1.Skip(1).ToArray();
                    text2 = text2.Skip(1).ToArray();
                }
                else
                {
                    text1 = text1.Skip(1).ToArray();
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(Convert.ToString(Scramble("scriptingjava","javascript")));
        }
    }
}
