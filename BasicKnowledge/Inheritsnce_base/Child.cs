using System;

namespace BasicKnowledge.Inheritsnce_base
{
    internal class Child : Parent
    {
        public Child(int i):base(i) // here base use to explicitly called the Child class construcor because child class does not has paremeterless constructor
        {
            Console.WriteLine("Child Constructor is called.");
        }
        public static void Main()
        {
            Child c = new Child(10);
        }
    }
}
