using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class FDCalculate
    {
        double principle = 1000000;
        int noOfDays = 31;
        double interest = 5;
        double amount;

        public void Calculate()
        {
            //amount = principle(1 + interest / 100) * noOfDays;
            amount = principle * interest * noOfDays / 100;
            Console.WriteLine("Amount =" + amount);

        }
    }
}
