﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMProtectedType
{
    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
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
            User u = new User();
            Program p = new Program();
            p.Name = "Avani Panchal";
            p.Location = "Ahmedabad";
            p.Age = 28;
            p.GetUserDetails();
            Console.ReadLine();
        }
    }
}
