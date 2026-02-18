using System;

namespace BasicKnowledge.Inheritance
{
    internal class Class2 : Class1
    {
        public Class2()
        {
            Console.WriteLine("Class 2 Constructor is called.");
        }
        public void Test3()
        {
            Console.WriteLine("Test 3");
        }
        public static void Main()
        {
            Class2 c = new Class2();
            c.Test1();
            c.Test2();
            c.Test3();
        }
    }
}
