using System;
namespace BasicKnowledge
{
    class Program
    {
        // here we demostrated that the impcit constructor(which initialize the i and ) is called and its created object that class
        int i;
        bool b;
        public static void Main(string[] args)
        {
            Program p = new Program();   
            Console.WriteLine(p.i);
            Console.WriteLine(p.b);
            Console.ReadLine();
        }
    }
}