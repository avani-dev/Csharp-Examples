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
        public void CreateFile()
        {
            if (File.Exists(@"D:/Avanee/1.txt"))
            {
                Console.WriteLine("File is already created");
                Console.WriteLine(File.GetCreationTime(@"D:/Avanee1.txt"));
                Console.WriteLine(File.GetLastAccessTime(@"D:/Avanee1.txt"));
            }
            else
            {
                File.Create(@"D:/Avanee/1.txt");
                Console.WriteLine("File is created");
                Console.WriteLine(File.GetCreationTime(@"D:/Avanee1.txt"));
                Console.WriteLine(File.GetLastAccessTime(@"D:/Avanee1.txt"));
            }
        }
        public void DirectoryInfo()
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:/Avanee");
            Console.WriteLine("FullName = " + dir.FullName);
            Console.WriteLine("Extention = " + dir.Extension);
            Console.WriteLine("GetType = " + dir.GetType());
            Console.WriteLine("LastWriteTime = " + dir.LastWriteTime);
            Console.WriteLine("Name = " + dir.Name);
            Console.WriteLine("CreationTime = " + dir.CreationTime);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            createDir cd = new createDir();
            cd.CreateDirectory();
            cd.CreateFile();
            Console.ReadLine();
        }
    }
}
