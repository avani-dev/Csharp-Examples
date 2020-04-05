using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WProperty
{
    class WriteProperty
    {
        string name;
        public string Name
        {
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
            WriteProperty w = new WriteProperty();
            w.Name = "Write Only Property";
            w.display();
            Console.ReadLine();
        }
    }
}
