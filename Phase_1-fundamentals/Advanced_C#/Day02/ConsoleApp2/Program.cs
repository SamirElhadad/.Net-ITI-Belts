using System.ComponentModel;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20 };
            void Calculate()
                {
                int GetSum()
                {
                    int sum = 0;
                    foreach (var num in numbers)
                    {
                        sum += num;
                    }
                    return sum;
                }
                int sum = GetSum();
                double average = (double)sum / numbers.Length;
                Console.WriteLine($"Sum: {sum}, Average: {average}");
            }
            Calculate();
        }
    }
}
