using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSample
{
    abstract class Employee
    {
        public void print()
        {
            Console.WriteLine("Non-abstract method");
        }
        public abstract void display();
    }

    class Mohit : Employee
    {
        public override void display()
        {
            Console.WriteLine("Abstract Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mohit m1 = new Mohit();
            m1.print();
            m1.display();
            Console.ReadLine();
        }
    }
}
