namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_11 Write a program to create a Simple Calculator using switch.


                Console.Write("Enter First Number : ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Second Number : ");
                int num2 = int.Parse(Console.ReadLine());
                Console.Write("Enter Operator (+, -, *, /) : ");
                char op = char.Parse(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        Console.WriteLine($"The Result is = {num1 + num2}");
                        break;
                    case '-':

                        Console.WriteLine($"The Result is = {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"The Result is = {num1 * num2}");
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            Console.WriteLine($"The Result is = {num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operator.");
                        break;
                }


            #endregion
        }
    }
}
