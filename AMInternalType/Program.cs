﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMInternalType
{
    class User
    {

        internal string Name;
        internal string Location;
        internal int Age;
        internal void GetUserDetails()

        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Avani Panchal";
            u.Location = "Des Plaines";
            u.Age = 30;
            u.GetUserDetails();
            Console.ReadLine();

        }
    }
}
