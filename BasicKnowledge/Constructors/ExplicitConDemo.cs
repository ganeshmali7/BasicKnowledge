using System;

namespace BasicKnowledge.Constructors
{
    class ExplicitConDemo
    {
        // here we demostrated that how explicit constructor is called when we create the object of class
        // now we can say that its special type of method that called when object is created of that class
        public ExplicitConDemo()
        {
            Console.WriteLine("Explicit constructor is called.");
        }
        public static void Main()
        {
            ExplicitConDemo obj1 = new ExplicitConDemo();
            ExplicitConDemo obj2 = new ExplicitConDemo();
            Console.ReadLine(); 
        }

    }
}
