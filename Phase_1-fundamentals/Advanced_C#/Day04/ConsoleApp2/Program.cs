namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee { Name = "Samir"   , Salary = 60000 , HiringDate = new DateTime(2020, 1, 15) },
                new Employee { Name = "Mostafa" , Salary = 55000 , HiringDate = new DateTime(2019, 3, 10) },
                new Employee { Name = "Ahmed"   , Salary = 70000 , HiringDate = new DateTime(2021, 6, 5) }
            };
            employees.Sort();
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Name}, {emp.Salary}, {emp.HiringDate.ToShortDateString()}");
            }
        }
    }
}
