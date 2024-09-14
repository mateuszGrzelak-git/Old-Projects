using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            human1.name = "Rick";
            human1.age = 65;

            human1.Eat();
            human1.Sleep();

            Console.ReadKey();
        }
    }
    class Human
    {
        public string name;
        public int age;
        public void Eat(){
            System.Console.WriteLine(name + " eating");
        }
        public void Sleep(){
            System.Console.WriteLine(name + " sleeping");
        }
    }
}
