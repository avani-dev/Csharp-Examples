using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassSample
{
    class GenericClass1<T, U>
    {
        T a;
        U b;
        public GenericClass1(T a1, U b1)
        {
            this.a = a1;
            this.b = b1;
            Console.WriteLine("This.a = " + this.a + "," + "This.b = " + this.b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass1<int, String> gc = new GenericClass1<int, string>(1, "Avaniii");
            Console.ReadLine();
        }
    }
}
