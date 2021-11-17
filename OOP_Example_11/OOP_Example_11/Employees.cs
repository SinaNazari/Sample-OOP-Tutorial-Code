using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_11
{
    public class Employees : Person
    {
        public string? CompanyName { get; set; }
        public string? CompanyLocation { get; set; }
        public double Salary { get; set; }

        public void Say()
        {
            Console.WriteLine("I'm Employees");
        }
    }
}
