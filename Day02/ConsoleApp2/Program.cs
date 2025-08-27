namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task_2 Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

                Console.Write("Enter your num: ");
                int number2 = int.Parse(Console.ReadLine());
                if (number2 > 0)
                {
                    Console.WriteLine("Positive");
                }
                else if (number2 < 0)
                {
                    Console.WriteLine("Negative");
                }
                else
                {
                    Console.WriteLine("Zero");
                }

            #endregion




        }
    }
}
