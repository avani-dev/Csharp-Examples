using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingSample
{
    class MyExecption : Exception
    {
        public MyExecption(String str)
        {
            Console.WriteLine("User defined Exception");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("Avani");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception caught here=" + ex.ToString());
            }
            Console.WriteLine("Last Statement");
            Console.ReadLine();
        }
    }
}
