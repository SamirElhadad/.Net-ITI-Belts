namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_7 Write a program that allows the user to insert an integer then print a multiplication table up to 12.

                Console.Write("Enter your num: ");
                int number = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write($" {number * i} ");
                }

            #endregion
        }
    }
}
