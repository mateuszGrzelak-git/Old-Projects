using System;

namespace a7
{
    class Program
    {
        public static string X(int n)
        {
            string solution = "";
            bool a = true;
            bool b = true;
            int bialy1 = 0;
            int bialy2 = n-1;
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (bialy1==bialy2&&bialy1==x &&bialy2==x && a && b)
                    {
                        solution+="■";
                        bialy1+=1;
                        bialy2-=1;
                        a=false;
                        b=false;
                    }
                    else if (bialy1==x && a)
                    {
                        solution+="■";
                        bialy1+=1;
                        a=false;
                    }
                    else if(bialy2==x && b)
                    {
                        solution+="■";
                        bialy2-=1;
                        b = false;
                    }
                    else
                    {
                        solution+="□";
                    }
                }
                solution+="\n";
                a=true;
                b=true;
            }
            return solution;
        }
        public static void Main(string[] args)
        {
            System.Console.WriteLine(X(15));           
        }
    }
}