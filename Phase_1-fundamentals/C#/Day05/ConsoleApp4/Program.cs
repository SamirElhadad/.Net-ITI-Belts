namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Ahmed");
            Student student2 = new Student("Samir", 20);

            student1.DisplayInfo(); 
            student2.DisplayInfo(); 

        }
    }
}
