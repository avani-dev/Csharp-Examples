using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    public delegate void Mydel1(int a, int b);

    class class1
    {
        public void sum(int a, int b)
        {
            Console.WriteLine("Sum of a+b is = " + (a+b));
        }
        public void sub(int a, int b)
        {
            Console.WriteLine("Sub of a-b is = " + (a - b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Mul of a*b is = " + (a*b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Div of a/b is = " + (a/b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            class1 c1 = new class1();
            Mydel1 m1 = new Mydel1(c1.sum);
            m1 += new Mydel1(c1.sub);
            m1 += new Mydel1(c1.Mul);
            m1 += new Mydel1(c1.Div);
            if(m1 != null)
            {
                m1(10, 2);
            }
            Console.ReadLine();
        }
    }
}
