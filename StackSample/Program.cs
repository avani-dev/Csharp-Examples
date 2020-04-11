using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push("C#");
            st.Push("C");
            st.Push(123);
            st.Push(111.12);
            foreach(object s in st)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("======POP=======");
            st.Pop();
            foreach(object s in st)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Constains = " + st.Contains("Text"));
            Console.WriteLine("Count = " + st.Count);
            Console.WriteLine("GetType = " + st.GetType());
            Console.WriteLine("GetHashCode = " + st.GetHashCode());
            Console.ReadLine();
        }
    }
}
