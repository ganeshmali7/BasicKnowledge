using System;

namespace BasicKnowledge.MethodOverriding
{
    internal class Class1
    {
        public void Test()
        {
            Console.WriteLine("Parent class Test method is called.");
        }
        public virtual void Show() // This is method overridable not mandatory 
        {
            Console.WriteLine("Parent Class Show method is called.");
        }
    }

    internal class Class2:Class1
    {
        // Method Overloading parents method in child class
        public void Test(int i)
        {
            Console.WriteLine("Child Class Test method is called.");
        }
        public override void Show() // Method overrided it's parent method we reimplemented
        {
            Console.WriteLine("Child Class Show method is called.");
        }
        public static void Main()
        {
            Class2 c = new Class2();
            c.Test();
            c.Test(1);
            c.Show();
        }
    }
    // If you want to override a parent's method under the child class first that method should be declared by using virtual modifier in parent class.

    // Mthod overriding is an approach of re-implementing a parent claasses method under the child class exactly with the same name and signature.

    // Method Hiding/Shadowing is also approach of reimplementing a parent classes method under the child class exactly with the same name and signature.

    // In the first case child class reimplements it's parent classes methods which are declared as virtual, where as in the second case
    // child class can reimplement any parents method even if method is not declared as virtual.
}
