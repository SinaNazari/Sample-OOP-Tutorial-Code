using System;
using System.IO;

namespace OOP_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadFile3();
            ReadFile4();
        }

        public static void ReadFile()
        {
            string filePath = @"C:\To\Test.txt";
            FileStream file = null;
            try
            {
                file = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var fileSize = file.ReadByte();
            }
            finally
            {
                file.Close();
            }
        }

        //Sample2 (FileStream)
        public static void ReadFile2()
        {
            var filePath = "C:\\To\\Test.txt";
            using (FileStream file = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                var fileSize = file.ReadByte();
            }
        }

        //Sample3 (StreamReader)

        public static void ReadFile3()
        {
            var filePath = "C:\\To\\Test.txt";
            using (var fileReader = new StreamReader(filePath))
            {
                var file = fileReader.ReadToEnd();
            }
        }

        //Sample4
        public static void ReadFile4()
        {
            var filePath = "C:\\To\\Test.txt";
            using (var fileReader = new StreamReader(filePath))
            {
                string line = null;
                while ((line = fileReader.ReadLine()) != null)
                {
                    var data = line.Split("\t");
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }
                   
                }
            }
        }
    }
}
