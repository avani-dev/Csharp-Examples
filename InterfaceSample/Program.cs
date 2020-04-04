using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    interface Addition
    {
        int Add();
    }
    interface Multiplication
    {
        int Mul();
    }
    class Number : Addition, Multiplication
    {
        public int a, b, c;
        public int Add()
        {
            a = 10;
            b = 20;
            c = a + b;
            return c;
        }
        public int Mul()
        {
            a = 10;
            b = 20;
            c = a * b;
            return c;
        }
    }

    class Program
    {
        public static void Main()
        {
            //Addition a1 = new Addition();
            Number n1 = new Number();
            int add1 = n1.Add();
            Console.WriteLine("Addition is = " + add1);
            int mul1 = n1.Mul();
            Console.WriteLine("Multiplication is = " + mul1);
            Console.ReadLine();
        }
    }
}
