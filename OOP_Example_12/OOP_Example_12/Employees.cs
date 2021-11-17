using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_12
{
    public class Employees :Person
    {
        public double salary;

        public Employees(string name, string family, double salary) : base(name, family)
        {
            this.salary = salary;
        }
    }
}
