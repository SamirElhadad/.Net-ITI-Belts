using System.Diagnostics.Metrics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string> { "Ali", "Sara", "Mona", "Abdullah", "Mohamed" };
            students.Add("Laila");
            students.Add("Omar");
            students.Add("Ali");
            students.Remove("Mona");
            Console.WriteLine("All Student Names:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            Console.WriteLine("Names Starting with 'A':");
            foreach (var student in students)
            {
                if (student.StartsWith("A"))
                {
                    Console.WriteLine(student);
                }
            }
        }
    }

}
