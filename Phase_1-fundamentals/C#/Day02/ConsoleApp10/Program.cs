namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_10 Write a program to enter marks of five subjects and calculate total, average and percentage.

                int totalMark = 0;
                int averageMark = 0;
                int Percentage = 0;
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Enter Your degree : ");
                    int degree = int.Parse(Console.ReadLine());

                    totalMark += degree;
                    averageMark = totalMark / 5;
                    Percentage = (totalMark * 100) / 500;
                }
                Console.WriteLine($"Total Mark is :{totalMark} \n Average Mark is :{averageMark} \n Percentage is :{Percentage}%");

            #endregion

        }
    }
}
