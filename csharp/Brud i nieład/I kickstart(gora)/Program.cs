using System;

namespace I_kickstart_gora_
{
    //https://www.codewars.com/kata/51b62bf6a9c58071c600001b
    class Program
    {
        static string rzymskie(int razy, string zestaw)
        {
            if (razy==0)
            {
                return "";
            }
            else
            {
                switch (switch_on)
                {
                    
                    default:
                }
            }
        }
        static string Check(int b)
        {
            switch (b)
            {
                case > 1000:
                return "M";
                case > 100:
                return "CDM";
                case > 10:
                return "XLM";
                default:
                return "IVX";
            }
        }
        static string solution(int n)
        {
            string solution = "";
            int a = Convert.ToInt32(Math.Ceiling(Math.Log10(n)));
            int b = Convert.ToInt32(Math.Pow(10,a));
            string c = Check(b);
            for (int i = 0; i < a; i++)
            {
                solution+=rzymskie(Math.Ceiling(n/b), c,n);
                b/=10;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
