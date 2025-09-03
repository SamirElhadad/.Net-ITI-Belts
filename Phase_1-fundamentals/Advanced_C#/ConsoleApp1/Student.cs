using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public List<int> Scores { get; set; }


        public Student(string name, int? age = null)
        {
            Name = name;
            Age = age;
            Scores = new List<int>();

        }

        public void AddScore(params int[] scores)
        {
            Scores.AddRange(scores);
        }
        public double? GetAverageScore()
        {

            return Scores.Count == 0 ? null : Scores.Average();
        }
    }
}