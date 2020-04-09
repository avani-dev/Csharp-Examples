using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//using System.Collections.Generic;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(123);
            list.Add(15);
            list.Add(100);
            foreach(int a in list)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
