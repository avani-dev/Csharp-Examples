using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCastDelegate
{
    public delegate void Mydel();
    public delegate void MyAdd(int a, int b);
    public delegate int MySub(int a, int b);

    class class1
    {
        public void display()
        {
            Console.WriteLine("This is single cast Delegate");
        }
        public void sum(int a, int b)
        {
            Console.WriteLine("Sum of a+b is :" + (a+b));
        }
        public int sub(int a, int b)
        {
            return (a - b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            class1 c1 = new class1();
            Mydel d1 = new Mydel(c1.display);
            d1();
            MyAdd d2 = new MyAdd(c1.sum);
            d2(10,20);
            MySub d3 = new MySub(c1.sub);
            int sub = d3(10,2);
            Console.WriteLine("Subtraction = " + sub);
            Console.ReadLine();
        }
    }
}
