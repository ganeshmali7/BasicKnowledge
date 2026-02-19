using System;

namespace BasicKnowledge.MethodOverloading
{
    internal class Class1
    {
        public void Test()
        {
            Console.WriteLine("1st Method");
        }
        public void Test(string s)
        {
            Console.WriteLine("2nd Method");
        }
        public void Test(int i)
        {
            Console.WriteLine("3rd Method");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("4th Method");
        }
        public void Test(int i, string s)
        {
            Console.WriteLine("5th Method");
        }
        public static void Main()
        {
            Class1 c = new Class1();
            c.Test();
            c.Test("Ganesh Mali");
            c.Test(20);
            c.Test("Ganesh Mali", 56);
            c.Test(45, "Ganesh Mali");

        }
    }
}
