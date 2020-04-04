using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMProtectedInternalType
{
    class User
    {

        protected internal string Name;
        protected internal string Location;
        protected internal int Age;
        protected internal void GetUserDetails()

        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }

    }
    class Program : User
    {
        static void Main(string[] args)
        {
            //User u = new User();
            Program u = new Program();
            u.Name = "Avani Panchal";
            u.Location = "Des Plaines";
            u.Age = 30;
            u.GetUserDetails();
            Console.ReadLine();

        }
    }
}