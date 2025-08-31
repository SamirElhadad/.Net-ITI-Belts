using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Student
    {

        public string Name;
        public int Age;

        public Student(string name )
        {
            Name = name;
            Age = 18;
        }

        public Student(string name, int age ) : this(name)
        {
            Age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} , Age: {Age}");
        }

    }
}
