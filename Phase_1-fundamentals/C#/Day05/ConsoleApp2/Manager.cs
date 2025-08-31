using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Manager : Employee
    {

        public override decimal CalculateBonus()
        {
            return Salary * 0.15m; 
        }

    }
}

