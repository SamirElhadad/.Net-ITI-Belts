namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_3 Write a program that takes 3 integers from the user then prints the max element and the min element.

                int maxNum = 0;
                int minNum = 0;
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($" Enter Your {i + 1}: ");
                    int number3 = int.Parse(Console.ReadLine());
                    if (number3 > maxNum)
                    {
                        maxNum = number3;
                    }
                    else
                    {
                        minNum = number3;
                    }
                }
                Console.WriteLine($"Max = {maxNum}");
                Console.WriteLine($"Mix = {minNum}");

            #endregion
        }
    }
}
