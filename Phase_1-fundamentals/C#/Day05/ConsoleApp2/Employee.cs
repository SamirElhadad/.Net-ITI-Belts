using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public virtual decimal CalculateBonus()
        {
            return Salary * 0.05m;
        }
    }
}
