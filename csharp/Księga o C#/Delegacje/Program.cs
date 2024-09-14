using System;

namespace Delegacje
{
    class Program
    {
        public delegate void SomeMethodDel();
        static void Main(string[] args)
        {
            SomeMethodDel someDele = SomeMethod;
            someDele.Invoke();//wywołaj*/
            SomeLongRunningData a = new SomeLongRunningData();
            a.SomeMethod(CallBackMethod);
        }


        static void SomeMethod()
        {
            System.Console.WriteLine("Jestem tu !!");
            System.Console.ReadKey();
        }
        static void CallBackMethod(int i/*musi być to samo co delegat*/)
        {
            System.Console.WriteLine(i);
        }
    }
}
//delegat - to variable
//delegat - tylko zwrot