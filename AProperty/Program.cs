using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProperty
{
    abstract class AbstractProperty
    {
        abstract public string Name
        {
            get;
            set;
        }
    }
    class class2 : AbstractProperty
    {
        string name;
        public override string Name 
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
            Console.WriteLine("name = " +name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class2 c2 = new class2();
            c2.Name = "Abstract Property";
            c2.display();
            Console.ReadLine();
        }
    }
}
