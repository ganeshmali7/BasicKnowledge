using System;
using System.Collections.Generic;
using System.Text;

namespace BasicKnowledge.AccessSpecifiers
{
    class Three
    {
        public static void Main()
        {
            AccessSpecifiersDemo obj = new AccessSpecifiersDemo();
            // here we not able to access the protected method because here we not used the inheritance.
            obj.Test2();
            obj.Test4();
            obj.Test5();
        }
    }
}


// to demostrate next we can create new project
// i f we creates new project here then-
// suppose there is class inheritce the our class from this project then methods which are not internal are accessible and
// if class inherits then protected method also accessible here 
// protected internal shows the OR means if one them is working then its works