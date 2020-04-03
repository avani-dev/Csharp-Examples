using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTypesSample
{
    //-------------- Single inheritance ------------
    //class ParentChildTest
    //{
    //    public void display()
    //    {
    //        Console.WriteLine("Parent class");
    //    }
    //}
    //class Child1 : ParentChildTest
    //{
    //    public void display1()
    //    {
    //        Console.WriteLine("Child class");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Child1 c1 = new Child1();
    //        c1.display1();
    //        c1.display();
    //        Console.ReadLine();
    //    }

    //}

    class A
    {
        public int a;
        //private int a;
        public void getA()
        {
            a = 10;
        }
        public int returnA()
        {
            return a;
        }
    }
    class B : A
    {
        public int b;
        public int sum = 0;
        protected int d;
        public void getB()
        {
            b = 20;
            sum = returnA() + b;
            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);
            Console.WriteLine("Sum =" + sum);
            d = sum;
            Console.WriteLine("d =" + d);
        }
    }
    class C : B
    {
        public int stored;
        public void getd()
        {
            stored = d;
            Console.WriteLine("Stored =" + stored);
        }
    }
    class class1
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            b1.b = 40;
            b1.getA();
            b1.getB();
            Console.ReadLine();
        }
    }
}
