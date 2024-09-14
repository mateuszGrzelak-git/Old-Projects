using System;
namespace Delegacje
{
    class SomeLongRunningData
    {
        public delegate void CallBack(int i);
        public void SomeMethod(CallBack obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                obj(i);
                //System.Console.WriteLine(i.ToString());
                //Robi się coś w tle nie wiemy gdzie
            }
            Console.ReadKey();
        }
    }
}