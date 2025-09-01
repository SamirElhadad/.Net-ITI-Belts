using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Professor : Person , ITeacher
    {
        public string department { get; set; }

        public decimal salary { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"\n(Professor) : , Id : {Id} , Name : {FullName} , Age : {Age} , Department : {department}, Salary : {salary}");
        }

        public void TeachCourse(string courseName)
        {
            Console.WriteLine($"\n{FullName} , is teaching {courseName} in the {department} department.");
        }
    }
}
