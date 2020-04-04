using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstSample
{
    class class1
    {
        //public class1()
        //{
        //    Console.WriteLine("Base class Constirctor");
        //}
        public int a;
        public int b;
        public class1(int a, int b)
        {
            this.a = a;
            this.b = b; 
            Console.WriteLine("this.a = " + this.a);
            Console.WriteLine("this.b = " + this.b);
        }
    }

    class class2 : class1
    {
        //public class2()
        //{
        //    Console.WriteLine("Child class Constructor");
        //}
        int c;
        public class2(int a1, int b1, int c1) : base(a1, b1)
        {
            c = c1;
            Console.WriteLine("c = " + c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class2 c2 = new class2(10, 20, 30);
            Console.ReadLine();
        }
    }
}
