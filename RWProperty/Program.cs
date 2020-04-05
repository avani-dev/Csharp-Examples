using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWProperty
{
    class class1
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void display()
        {

            Console.WriteLine("name = " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.Name = "Read and Write Property";
            c1.display();
            Console.ReadLine();
        }
    }
}
