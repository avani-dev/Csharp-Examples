using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RProperty
{
    class ReadProperty
    {
        string name;
        public ReadProperty(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
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
            ReadProperty r = new ReadProperty("This is Read Only Property");
            r.display();
            Console.ReadLine();
        }
    }
}
