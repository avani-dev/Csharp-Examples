using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Default_Const
    {
        int age, rollno;
        public Default_Const()
        {
            rollno = 10;
            age = 20;
        }
        public void print()
        {
            Console.WriteLine("Rollno =" + rollno + "," + "Age =" + age);
        }

    }
}
