namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee manager = new Manager()
            {
                Name = "Samir Elhadad",
                Salary = 100
            };
            Console.WriteLine($"Manager: {manager.Name} , Salary: {manager.Salary} , Bonus: {manager.CalculateBonus()}");

            Employee developer = new Developer()
            {
                Name = "Samir Mostafa",
                Salary = 100
            };
            Console.WriteLine($"Developer: {developer.Name} , Salary: {developer.Salary} , Bonus: {developer.CalculateBonus()}");

            Employee employee = new Employee()
            {
                Name = "Ahmed Mostafa",
                Salary = 100
            };
            Console.WriteLine($"Employee: {employee.Name} , Salary: {employee.Salary} , Bonus: {employee.CalculateBonus()}");

        }
    }
}
