using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_11
{
    public class Student : Person
    {
        public string? UniversityName{ get; set; }
        public string? UniversityLocation { get; set; }
        public int UniversituRank { get; set; }

        public void Say()
        {
            Console.WriteLine("I'm Student");
        }
    }
}
