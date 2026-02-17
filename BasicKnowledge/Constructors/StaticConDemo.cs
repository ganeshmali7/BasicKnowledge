using System;

namespace BasicKnowledge.Constructors
{
    class StaticConDemo
    {
        // if class has the static variables then implicit static constructor comes in picture and also then implicit constructor is always created as we know.
        // Static constructor are resposible for in initializing static variables adn these consturctor never called explicitly and more over these consturtor first to execute.
        // Static constructor can not be parameterized, there fore overloading is not possible.
        static StaticConDemo() // First block to be executed before main method, here note that program execution starts from the Main method but static constructor excecuted before execution of main method
        {
            Console.WriteLine("Static Constructor");
        }
        static void Main()
        {
            Console.WriteLine("Main method is called.");
        }

    }
}
