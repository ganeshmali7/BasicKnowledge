using System;

namespace BasicKnowledge.Inheritance
{
    internal class Class3
    {
        public static void Main()
        {
            Object obj = new Object(); // this is by default parent class of every class
            Console.WriteLine(obj.GetType()); // System.Object
            Class3 c3 = new Class3();
            Console.WriteLine(c3.GetType()); // BasicKnowledge.Inheritance.Class3
            // Equals, GetHashCode, ToString, GetType - methods available in Object class which available in System namespace 
        }
    }
}
