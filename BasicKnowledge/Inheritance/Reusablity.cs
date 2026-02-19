using System;

namespace BasicKnowledge.Inheritance
{
    internal class Reusablity
    {
        class Person
        {
            public int Id;
            public string Name, Address, Phone;
        }
        class Student : Person
        {
            char Cls;
            float Fees, Marks;
            string grade;
        }
        class Staff : Person
        {
            float salary;
            string designation;
        }
        class Teaching : Staff
        {
            string Qualification, Subject;
        }
        class NonTeaching : Staff
        {
            string Dname;
            int MgrId;
        }
    }
}

// Here we demostrated that how we implement inheritance for reusability



