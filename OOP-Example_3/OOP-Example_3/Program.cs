using System;
using System.IO;

namespace OOP_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void ReadFile()
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
    }
}
