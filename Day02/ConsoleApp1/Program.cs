using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task_1 Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("Enter your num: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region Task_2 Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.Write("Enter your num: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Zero");
            //}

            #endregion

            #region Task_3 Write a program that takes 3 integers from the user then prints the max element and the min element.

            //int maxNum = 0;
            //int minNum = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($" Enter Your {i + 1}: ");
            //    int num = int.Parse(Console.ReadLine());
            //    if (num > maxNum)
            //    {
            //        maxNum = num;
            //    }
            //    else
            //    {
            //        minNum = num;
            //    }
            //}
            //Console.WriteLine($"Max = {maxNum}");
            //Console.WriteLine($"Mix = {minNum}");

            #endregion

            #region Task_4 Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Enter your num: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            #endregion

            #region Task_5 Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.Write("Enter your char: ");
            //char ch = char.Parse(Console.ReadLine());
            //char[] vowelStr = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' }
            //;
            //foreach (char i in vowelStr)
            //{
            //    if (ch == i)
            //    {
            //        Console.WriteLine("Vowel");
            //        return;
            //    }
            //}
            //Console.WriteLine("Consonant");
            #endregion

            #region Task_6 Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter your num: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i < number; i++)
            //{
            //    Console.Write($" {i} ");
            //}

            #endregion

            #region Task_7 Write a program that allows the user to insert an integer then print a multiplication table up to 12.


            //Console.Write("Enter your num: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($" {number*i} ");
            //}

            #endregion

            #region Task_8 Write a program that allows to user to insert number then print all even numbers between 1 to this number.

            //Console.Write("Enter your num: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++) {
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($" {i} ");
            //    }
            //}

            #endregion

            #region Task_9 Write a program that takes two integers then prints the power.

            //Console.Write("Enter The Number : ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Entet The Power : ");
            //int power = int.Parse(Console.ReadLine());

            //int result = 1;
            //for (int i = 1; i <= power; i++)
            //{
            //    result *= number;
            //}
            //Console.WriteLine($"The Result Of {number} ^ {power} is = {result}");

            #endregion

            #region Task_10 Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int totalMark = 0;
            //int averageMark = 0;
            //int Percentage = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write("Enter Your degree : ");
            //    int degree = int.Parse(Console.ReadLine());

            //    totalMark += degree;
            //    averageMark = totalMark / 5;
            //    Percentage = (totalMark * 100) / 500;
            //}
            //Console.WriteLine($"Total Mark is :{totalMark} \n Average Mark is :{averageMark} \n Percentage is :{Percentage}%");

            #endregion

            #region Task_11 Write a program to create a Simple Calculator using switch.

            //Console.Write("Enter First Number : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Number : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Operator (+, -, *, /) : ");
            //char op = char.Parse(Console.ReadLine());
            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine($"The Result is = {num1 + num2}");
            //        break;
            //    case '-':

            //        Console.WriteLine($"The Result is = {num1 - num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"The Result is = {num1 * num2}");
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine($"The Result is = {num1 / num2}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Error: Invalid operator.");
            //        break;
            //}

            #endregion

            #region Task_12 Write a program that takes elements of an array from the user and calculates the sum of only even numbers

            //Console.Write("Enter the Length of the array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] numbers = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int sumEven = 0;
            //foreach (int num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        sumEven += num;
            //    }
            //}
            //Console.WriteLine($"The sum of even numbers in the array is: {sumEven}");


            #endregion







        }
    }
}