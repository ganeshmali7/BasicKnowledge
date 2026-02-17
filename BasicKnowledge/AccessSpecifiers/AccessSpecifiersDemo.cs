using System;

namespace BasicKnowledge.AccessSpecifiers
{
    public class AccessSpecifiersDemo
    {
        private void Test1()
        {
            Console.WriteLine("Private Method.");
        }

        internal void Test2()
        {
            Console.WriteLine("Internal Method.");
        }

        protected void Test3()
        {
            Console.WriteLine("Protected Method.");
        }

        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal Method.");
        }

        public void Test5()
        {
            Console.WriteLine("Public Method.");
        }

        public static void Main(string[] args) 
        {
            AccessSpecifiersDemo obj = new AccessSpecifiersDemo();
            obj.Test1();
            obj.Test2();
            obj.Test3();
            obj.Test4();
            obj.Test5();
        }
    }
}
