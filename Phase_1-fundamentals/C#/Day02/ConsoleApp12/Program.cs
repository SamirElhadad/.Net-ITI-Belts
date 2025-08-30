namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_12 Write a program that takes elements of an array from the user and calculates the sum of only even numbers

                Console.Write("Enter the Length of the array: ");
                int size = int.Parse(Console.ReadLine());
                int[] numbers9 = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter element {i + 1}: ");
                    numbers9[i] = int.Parse(Console.ReadLine());
                }
                int sumEven = 0;
                foreach (int num in numbers9)
                {
                    if (num % 2 == 0)
                    {
                        sumEven += num;
                    }
                }
                Console.WriteLine($"The sum of even numbers in the array is: {sumEven}");

            #endregion
        }
    }
}
