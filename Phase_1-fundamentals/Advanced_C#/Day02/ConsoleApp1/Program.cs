namespace ConsoleApp1
{
    internal class Program
    {
        static void CheckEmployeeRole(Employee emp)
        {
            if (emp is Manager)
                Console.WriteLine($"{emp.Name} (Manager): Approve Budget & Conduct Meetings , Her Salary Is : {emp.Salary:C}");
            else if (emp is Admin)
                Console.WriteLine($"{emp.Name} (Admin): Manage Users & Handle Permissions , Her Salary Is : {emp.Salary:C}");
            else if (emp is Staff)
                Console.WriteLine($"{emp.Name} (Staff): Perform Daily Tasks , Her Salary Is : {emp.Salary:C}");
            else
                Console.WriteLine("Unknown Role");
            }
        static void Main(string[] args)
        {

            Employee[] employees = new Employee[]
            {
                new Manager("Samir", 90000 ),
                new Admin("Ehab", 60000 ),
                new Staff("Zeyad", 4000 )
            };

            foreach (var emp in employees)
            {
                CheckEmployeeRole(emp);
            }
        }
    }
}
