using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("C#");
            arr.Add('C');
            arr.Add(123);
            foreach(object a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("=====Insert======");
            arr.Insert(1, 200);
            foreach(object a in arr)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Index of element = " + arr.IndexOf("C#"));
            Console.WriteLine("Count = " + arr.Count);
            Console.WriteLine("Capacity = " + arr.Capacity);
            Console.WriteLine("Contains = " + arr.Contains("Test"));
            Console.WriteLine("Remove Method");
            // arr.Remove("C#");
            Console.ReadLine();
        }
    }
}
