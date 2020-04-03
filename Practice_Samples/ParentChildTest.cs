using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Samples
{
    class ParentChildTest
    {
        public void display()
        {
            Console.WriteLine("Parent class");
        }
    }
    class Child1 : ParentChildTest
    {
        public void display1()
        {
            Console.WriteLine("Child class");
        }
    }
}
