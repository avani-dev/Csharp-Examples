using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTPolymorphism
{
    public class TestData
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestData td = new TestData();
            int Add1 = td.Add(10,20);
            int Add2 = td.Add(30,40,50);
            Console.WriteLine("Addition of two number is : " + Add1);
            Console.WriteLine("Addition of three number is : " + Add2);
            Console.ReadLine();
           
        }
    }
}
