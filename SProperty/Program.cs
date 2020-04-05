using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SProperty
{
    class StaticProperty
    {
        static string name;
        public static string Name
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
            StaticProperty s = new StaticProperty();
            StaticProperty.Name = "Static Property";
            s.display();
            Console.ReadLine();
        }
    }
}
