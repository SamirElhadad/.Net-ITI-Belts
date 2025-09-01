using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Person
    {
        private string major;
        private double gpa;
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public double Gpa
        {
            get { return gpa; }
            set
            {
                if (value < 0.0 || value > 4.0)
                {
                    throw new ArgumentException("GPA must be between 0.0 and 4.0");
                }
                else
                {
                    gpa = value;
                }
            }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"\nStudent Info : , ID : {Id} , Name : {FullName} , Age : {Age} , Major : {Major} , GPA : {Gpa}");
        }

        public void RegisterCourse(string courseName)
        {
            Console.WriteLine($"\n{FullName} , registered for {courseName}.");
        }

        public void RegisterCourse(string courseName, int credits)
        {
            Console.WriteLine($"\n{FullName} , registered for {courseName} ({credits} credits).");
        }
    }
}
