namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_8 Write a program that allows to user to insert number then print all even numbers between 1 to this number.


                Console.Write("Enter your num: ");
                int number7 = int.Parse(Console.ReadLine());
                for (int i = 1; i <= number7; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($" {i} ");
                    }
                }


            #endregion
        }
    }
}
