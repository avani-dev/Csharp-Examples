using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    public delegate void Mydel1();
    class class1
    {
        public event Mydel1 Click;
        public void Click_Method()
        {
            Console.WriteLine("Click functionality access");
        }
        public void display()
        {
            Click += new Mydel1(Click_Method);
            Click();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.display();
            Console.ReadLine();
        }
    }
}
