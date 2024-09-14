using System;

namespace value_vs_ref
{
    class Program
    {
        static void Main(string[] args)
        {
          int a = 20;
 Console.WriteLine("Inside Main - Before Callee: a = {0}", a);
 Callee(a);
 Console.WriteLine("Inside Main - After Callee: a = {0}", a);
 
 Console.WriteLine("Inside Main - Before CalleeRef: a = {0}", a);
 CalleeRef(ref a);
 Console.WriteLine("Inside Main - After CalleeRef: a = {0}", a);
 
 Console.WriteLine("Inside Main - Before CalleeOut: a = {0}", a);
 CalleeOut(out a);
 Console.WriteLine("Inside Main - After CalleeOut: a = {0}", a);
 
 Console.ReadLine();
 }
 static void Callee(int a)
 {
 a = 5;
 Console.WriteLine("Inside Callee a : {0}", a);
 }
 static void CalleeRef(ref int a)
 {
 a = 6;
 Console.WriteLine("Inside CalleeRef a : {0}", a);
 }
 
 static void CalleeOut(out int a)
 {
 a = 7;
 Console.WriteLine("Inside CalleeOut a : {0}", a);   
        }
    }
}
