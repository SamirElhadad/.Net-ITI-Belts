namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_6 Write a program that allows the user to insert an integer then print all numbers between 1 to that number.


                Console.Write("Enter your num: ");
                int number5 = int.Parse(Console.ReadLine());
                for (int i = 1; i < number5; i++)
                {
                    Console.Write($" {i} ");
                }


            #endregion
        }
    }
}
