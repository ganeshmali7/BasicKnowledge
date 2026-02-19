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


            Class1 p;
            Class2 c2 = new Class2();
            p = c2;
            p.Test1();
            p.Test2();
            // p.Test3(); // We can not do this because we created reference of parent that points to the child class, so we can access all methods of parent class not in child class
            // as we know we can not access the child methods using parent class object
            // By default class inheritace the Object Class - parent class
        }
    }
}