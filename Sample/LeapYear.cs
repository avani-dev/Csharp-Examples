using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class LeapYear
    {
       public static void IsLeapYear()
        {
            int year;
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("no leap year");
            }
        }
    }
}

