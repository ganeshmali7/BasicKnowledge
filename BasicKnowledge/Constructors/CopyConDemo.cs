using System;

namespace BasicKnowledge.Constructors
{
    class CopyConDemo
    {
        // Id we want to create multiple instances with same values then we use these copy
        // constructors, in a copy constructor the constructor take same class as parameter to it.

        int x;
        public CopyConDemo(int i) // Parametrized Constructor
        {
            x = i;
        }
        public CopyConDemo(CopyConDemo obj) // Copy Constructor
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine(x);
        }
        public static void Main()
        {
            CopyConDemo obj1 = new CopyConDemo(10);
            CopyConDemo obj2 = new CopyConDemo(obj1);
            obj1.Display();
            obj2.Display();
            Console.ReadLine();
        }
    }

}
