using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class NestedIf
    {
        public static void CalculatePer()
        {
        int maths = 100;
        int science = 100;
        int eng = 100;
        int computer = 90;
        int soc = 90;
        
            int total = maths + science + eng + computer + soc;
            double per = total/5;
            Console.WriteLine("total Marks =" + total);
            Console.WriteLine("Percentage =" + per);
            if (per>= 90 && per<=100)
            {
                Console.WriteLine("first");
            }
            else if(per>=70 && per<=89)
            {
                Console.WriteLine("Second");
            }
            else if(per>=50 && per<=69)
            {
                Console.WriteLine("Third");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
