using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; }

        public int CompareTo(Employee other)
        {
            int res = this.HiringDate.Year.CompareTo(other.HiringDate.Year);
            if (res == 0)
            {
              res = this.HiringDate.Month.CompareTo(other.HiringDate.Month);
            }
            if (res == 0)
            {
              res = this.HiringDate.Day.CompareTo(other.HiringDate.Day);
            }
            return res;
        }
        
    }
}
