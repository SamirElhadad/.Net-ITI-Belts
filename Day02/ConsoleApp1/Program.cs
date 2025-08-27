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

            Console.Write("Enter your num: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            #endregion

        }
    }
}