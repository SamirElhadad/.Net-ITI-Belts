using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public double Grade  { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {FullName}, Grade: {Grade}");
        }
    }
}
