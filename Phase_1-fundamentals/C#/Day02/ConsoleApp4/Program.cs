namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_4 Write a program that allows the user to insert an integer number then check If a number is even or odd.

            Console.Write("Enter your num: ");
            int number4 = int.Parse(Console.ReadLine());
            if (number4 % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            #endregion
        }
    }
}
