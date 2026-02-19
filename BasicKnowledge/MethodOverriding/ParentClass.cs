using System;


namespace BasicKnowledge.MethodOverriding
{
    internal class ParentClass
    {
        // Demostration for Method Hiding/Shadowing
        public virtual void Test1() // virtual method
        {
            Console.WriteLine("Test1 Method from Parent class.");
        }
        public void Test2() // not declared as virtual
        {
            Console.WriteLine("Test2 Method from Parent class.");
        }
    }

    class ChildClass : ParentClass
    {
        public override void Test1() // override method
        {
            Console.WriteLine("Test1 Method from Child class.");
        }
        public new void Test2() // new(programmer intenationally try to do this) - Method Hiding/Shadowing
        {
            Console.WriteLine("Test2 Method from Parent class.");
        }
        public static void Main()
        {
            ChildClass c = new ChildClass();
            c.Test1();
            c.Test2();
        }
    }
}
