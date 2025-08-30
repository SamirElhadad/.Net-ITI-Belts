using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1

            Console.Write("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Age is : {age}");

            //Task_2

            //String name = "Samir";
            //Convert.ToInt32(name); // Invalid Cast Exception and crash the program
            //Console.WriteLine($"Your Name is : {name}");

            //Task_3

            float num1 = 19.5f;
            float num2 = 20.2f;
            float result = num1 + num2;
            Console.WriteLine($"The result is: {result}"); // The result is: 39.7

            //Task_4

            int number = 10;
            int number1 = number;
            number1 = 20; // modifying the value of number1
            Console.WriteLine($"The number is: {number}"); // The number is: 20

            //Task_5

            int[] numbers3 = { 1, 2, 3, 4, 5 };
            int[] numbers4 = numbers3;
            numbers4[0] = 10; // modifying the first element of numbers1
            Console.WriteLine($"The first element is: {numbers3[0]}"); // The first element is: 10


            //Task_6

            Console.WriteLine("Enter Your first Name  : ");
            String firstName = Console.ReadLine();
            Console.WriteLine("Enter Your last Name  : ");
            String lastName = Console.ReadLine();
            String fullName = firstName + " " + lastName;
            Console.WriteLine($"Full Name is: {fullName}"); // Full Name is: Samir Elhadad

            //Task_7
            //b
            //d
            //d


        }
    }
}
