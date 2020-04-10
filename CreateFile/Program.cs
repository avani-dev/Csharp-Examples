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
            if (Directory.Exists(@"D:/Avanee"))
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
        public void CreateFile1()
        {
            if (File.Exists(@"D:/Avanee/1.txt"))
            {
                Console.WriteLine("File is already created");
                Console.WriteLine(File.GetCreationTime(@"D:/Avanee/1.txt"));
                Console.WriteLine(File.GetLastAccessTime(@"D:/Avanee/1.txt"));
            }
            else
            {
                File.Create(@"D:/Avanee/1.txt");
                Console.WriteLine("File is created");
                Console.WriteLine(File.GetCreationTime(@"D:/Avanee/1.txt"));
                Console.WriteLine(File.GetLastAccessTime(@"D:/Avanee/1.txt"));
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
        public void FileInfo()
        {
            FileInfo file = new FileInfo(@"D:/Avanee/1.txt");
            Console.WriteLine("FullName = " + file.FullName);
            Console.WriteLine("Extention = " + file.Extension);
            Console.WriteLine("GetType = " + file.GetType());
            Console.WriteLine("LastWriteTime = " + file.LastWriteTime);
            Console.WriteLine("Name = " + file.Name);
            Console.WriteLine("CreationTime = " + file.CreationTime);

        }

        public void WriteFile()
        {
            FileStream fs;
            StreamWriter sw;
            try
            {
                fs = new FileStream(@"D:/Avanee/1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                string str;
                Console.WriteLine("Enter the String");
                str = Console.ReadLine();
                sw.Write(str);
                sw.Flush();
                sw.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ReadFromFile()
        {
            FileStream fs = new FileStream(@"D:/Avanee/1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str;
            str = sr.ReadToEnd();
            while (str != null)
            {
                Console.WriteLine(str);
                str = Console.ReadLine();

            }
        }
        public void ReadInformation()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:/Windows");
            FileInfo[] infofile = dir.GetFiles();
            foreach (FileInfo f in infofile)
            {
                Console.WriteLine("Name=" + f.Name + "," + "Length=" + f.Length);

            }
        }

        public void Binary_Write_Read()
        {
            FileStream f111 = new FileStream(@"D:/Avanee/f111.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(f111);
            bw.Write("Synehcron");
            bw.Write(1000);
            bw.Write(123.4);
            bw.Write('c');
            bw.Flush();
            f111.Close();
            FileStream f1111 = new FileStream(@"D:/Avanee/f111.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(f1111);
            string str = br.ReadString();
            int m = br.ReadInt32();
            double m1 = br.ReadDouble();
            char ch1 = br.ReadChar();
            Console.WriteLine("str=" + str + "," + "m=" + m + "," + "m1=" + m1 + "," + "ch1=" + ch1);
            br.Close();
            f1111.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            createDir cd = new createDir();
            cd.CreateDirectory();
            cd.CreateFile();
            cd.DirectoryInfo();
            cd.CreateFile1();
            cd.FileInfo();
            cd.WriteFile();
            cd.ReadFromFile();
            cd.ReadInformation();
            cd.Binary_Write_Read();
            Console.ReadLine();
        }
    }

}