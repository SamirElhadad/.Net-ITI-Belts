namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Samir", 900000, ".Net Developer");
            manager.Introduce();
            manager.Work();
            manager.Manage();
        }
    }
}
