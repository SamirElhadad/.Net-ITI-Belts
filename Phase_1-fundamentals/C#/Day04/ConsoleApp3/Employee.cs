using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Employee : Person
    {
        public int Salary { get; set; }
        public Employee(string name, int salary) : base(name)
        {
            Salary = salary;
        }
        public void Work()
        {
            Console.WriteLine($"{Name} is working and earns {Salary}.");
        }

    }

}
