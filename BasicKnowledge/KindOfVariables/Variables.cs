using System;
using System.Diagnostics;

namespace BasicKnowledge.KindOfVariables
{
    

    internal class Variables
    {
        int x = 100; //Non-static or instance variable variable - does required instance of class for initializationor execution also 
        // We CAN USE RHE N
        static int y = 200; // static modifier used so it's static variable
        public static void Main()
        {
            //  z; // Static : here note that the variable declared within static block is also static variable
            Console.WriteLine(y); // y does not required the instance to access it but if i want to access variable x then needs to create instance of class
            Variables v1 = new Variables();
            Console.WriteLine(v1.x);

            Variables v2 = new Variables();
            Console.WriteLine(v2.x);
            // here 2 times memory is created for x where in object v1 aand v2
            Console.ReadLine();
        }
    }
}
