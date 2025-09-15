namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write($"Enter Your First Number : ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter Your Second Number : ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"The Result is : {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }

            finally
            {
                Console.WriteLine("Program finished.");
            }
        }
    }

}
