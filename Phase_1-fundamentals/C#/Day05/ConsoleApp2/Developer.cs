using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Developer : Employee
    {
        public override decimal CalculateBonus()
        {
            return Salary * 0.10m;
        }
    }
}
