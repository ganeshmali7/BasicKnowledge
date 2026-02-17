using System;
using System.Collections.Generic;
using System.Text;

namespace BasicKnowledge.AccessSpecifiers
{
    class Two: AccessSpecifiersDemo
    {
        public static void Main()
        {
            Two obj = new Two();
            // here we can not access the private method that it's scope is only upto the that class.
            //obj.Test1();
            obj.Test2();
            obj.Test3();
            obj.Test4();
            obj.Test5();
        }
    }
}
