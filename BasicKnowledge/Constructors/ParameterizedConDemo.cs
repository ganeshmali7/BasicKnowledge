using System;

namespace BasicKnowledge.Constructors
{
    class ParameterizedConDemo
    {
        int x;
        public ParameterizedConDemo(int i)
        {
            Console.WriteLine("Parametrized Constructor is called.");
            x = i;
        }
        
        public void display()
        {
            Console.WriteLine(x);
        }
        public static void Main()
        {
            ParameterizedConDemo obj1 = new ParameterizedConDemo(10);
            ParameterizedConDemo obj2 = new ParameterizedConDemo(20);

            obj1.display();
            obj2.display(); 

            Console.ReadLine();
        }
    }
}
