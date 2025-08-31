namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

         
            int sum1 = calc.Add(1, 2);            
            double sum2 = calc.Add(1.5, 2.5);      
            int sum3 = calc.Add(1, 2, 3);          

            Console.WriteLine($"Sum of 2 integers: {sum1}");
            Console.WriteLine($"Sum of 2 doubles: {sum2}");
            Console.WriteLine($"Sum of 3 integers: {sum3}");
        }
    }
}
