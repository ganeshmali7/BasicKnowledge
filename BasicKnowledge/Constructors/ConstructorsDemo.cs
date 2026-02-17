using System;

namespace BasicKnowledge.Constructors
{
    // Static constructors implicitly called.
    // Non-static constructors are explicitly called.
    class ConstructorsDemo
    {
        static int x; // one and one copy for all classes
        int y; // seperately created for each object when intanciated
        static ConstructorsDemo() // must be parameterless because static constructors are implicitely called. It's first block of code to run under the class.
        {
            Console.WriteLine("Static called.");
        }

        public ConstructorsDemo()
        {
            Console.WriteLine("Non-static called.");
        }

        static void Main()
        {
            Console.WriteLine("Main is called.");
            ConstructorsDemo obj1 = new ConstructorsDemo();
            ConstructorsDemo obj2 = new ConstructorsDemo();
            ConstructorsDemo obj3 = new ConstructorsDemo();
            Console.WriteLine(x);
            Console.WriteLine(obj1.y);
        }
    }
}
