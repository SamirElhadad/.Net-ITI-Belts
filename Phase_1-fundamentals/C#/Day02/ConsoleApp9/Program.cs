namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_9 Write a program that takes two integers then prints the power.

                Console.Write("Enter The Number : ");
                int number8 = int.Parse(Console.ReadLine());
                Console.Write("Entet The Power : ");
                int power = int.Parse(Console.ReadLine());

                int result = 1;
                for (int i = 1; i <= power; i++)
                {
                    result *= number8;
                }
                Console.WriteLine($"The Result Of {number8} ^ {power} is = {result}");

            #endregion
        }
    }
}
