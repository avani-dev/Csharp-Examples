using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class EvenOddNumber
    {
        public static void EvenOddNum()
        {
            int a;
            Console.WriteLine("Enter the Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a % 2 == 0 ? "Even Number" : "Odd Number");
        }
    }
}
