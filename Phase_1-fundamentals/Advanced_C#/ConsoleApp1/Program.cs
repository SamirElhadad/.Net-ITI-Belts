namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new List<Student>
            {
                new Student("Samir", 20),
                new Student("Amr", 9),
                new Student("Mohamed", 14),
                new Student("Ahmed")
            };


            student[0].AddScore(90, 80, 70);
            student[1].AddScore(90, 90, 90);
            student[2].AddScore(50, 60, 70);
            student[3].AddScore(80, 80, 90);
            

            string scoreToAdd = "80";
            if (int.TryParse(scoreToAdd, out int parsedScore))
            {
                student[2].AddScore(parsedScore);
            }

            Console.WriteLine("===> All Students Details <===");
            foreach (var s in student)
            { 
                var studentDetails = new
                {
                    s.Name,
                    s.Age,
                    AverageScore = s.GetAverageScore()
                };
                Console.WriteLine($"Name: {studentDetails.Name}, Age: {studentDetails.Age?.ToString() ?? "Null"}, Average Score: {studentDetails.AverageScore?.ToString("F2") ?? "Null"}");
            }


            Console.WriteLine("\n===> High Achievers (Avg > 80) <===");
            var highAchievers = student.Where(s => s.GetAverageScore() > 80);

            foreach (var x in highAchievers)
            {
                Console.WriteLine($"Name: {x.Name}, Average Score: {x.GetAverageScore()?.ToString("F2")}");
            }

        }
    }
}
