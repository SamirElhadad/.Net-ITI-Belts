namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student
            {
                Id = 1,
                FullName = "Samir Elhadad",
                Age = 20,
                Major = "Computer & Artificial Intelligence",
                Gpa = 4.0
            };

            // Create Professor
            Professor p1 = new Professor
            {
                Id = 101,
                FullName = "Eng. Mostafa Helal",
                Age = 28,
                department = "Computer Science",
                salary = 15000
            };

            
            s1.DisplayInfo();
            s1.RegisterCourse("OOP");
            s1.RegisterCourse("Data Structures", 3);

            p1.DisplayInfo();
            p1.TeachCourse("Dot Net");

            Console.WriteLine();

            Console.WriteLine("--- Polymorphism Demo ---");

            
            Person personRef;

            personRef = s1;  
            personRef.DisplayInfo();

            personRef = p1;  
            personRef.DisplayInfo();

        }
    }
}
