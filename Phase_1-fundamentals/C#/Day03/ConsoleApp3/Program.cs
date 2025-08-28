using ConsoleApp1;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_3 Automatic Property

                Student student = new Student();

                Console.Write("Enter Your Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                student.Id = id;

                Console.Write("Enter Your Full Name: ");
                string name = Console.ReadLine();
                student.FullName = name;

                Console.Write("Enter Your Grade: ");
                double grade = Convert.ToDouble(Console.ReadLine());
                student.Grade = grade;

                student.DisplayInfo();

            #endregion
        }
    }
}
