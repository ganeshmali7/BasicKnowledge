using System;
using System.Diagnostics;

namespace BasicKnowledge.KindOfVariables
{
    

    internal class Variables
    {
        int x = 100; //Non-static or instance variable variable - does required instance of class for initializationor execution also 
        // We CAN USE RHE N
        static int y = 200; // static modifier used so it's static variable
        const float pi = 3.14f; // Same as the static - once execution starts its memory allocated 
        // difference bet static and const is that static value we can update it, but const value can not be updatable
        readonly int a;
        public Variables(int i)
        {
            a = i; // assigning i value to a (readonly variable)
        }
        // we can not modify the value of a after initializing
        public static void Main()
        {
            //  z; // Static : here note that the variable declared within static block is also static variable
            Console.WriteLine(y); // y does not required the instance to access it but if i want to access variable x then needs to create instance of class
            Variables v1 = new Variables(10);
            Console.WriteLine(v1.x);
            // v1.a = 450; // can not able to update value of a which demostrate- readonly variables (uncomment for checking)
            Variables v2 = new Variables(20);
            Console.WriteLine(v2.x);
            // here 2 times memory is created for x where in object v1 aand v2
            Console.ReadLine();
        }
    }
}
