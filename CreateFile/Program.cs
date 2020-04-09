using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateFile
{
    class createDir
    {
        public void CreateDirectory()
        {
            if(Directory.Exists(@"D:/Avanee"))
            {
                Console.WriteLine("Directory is already created");
                Console.WriteLine(Directory.GetCreationTime(@"D:/Avanee"));
                Console.WriteLine(Directory.GetLastAccessTime(@"D:/Avanee"));
            }
            else
            {
                Directory.CreateDirectory(@"D:/Avanee");
                Console.WriteLine("Directory is created");
                Console.WriteLine(Directory.GetCreationTime(@"D:/Avanee"));
                Console.WriteLine(Directory.GetLastAccessTime(@"D:/Avanee"));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            createDir cd = new createDir();
            cd.CreateDirectory();
            Console.ReadLine();
        }
    }
}
