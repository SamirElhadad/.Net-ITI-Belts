using System;
using System.Diagnostics.Metrics;
using System.Threading.Channels;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1 , 2 , 3 };
            Console.WriteLine("Array before calling ModifyArray(): " + string.Join(", ", numbers));
            void ModifyArray(int[] arr)
            {
                arr[0] = 100; 
                arr = new int[] { 9, 9, 9 }; 
            }
            ModifyArray(numbers);
            Console.WriteLine("Array after calling ModifyArray(): " + string.Join(", ", numbers));


        }
    }
}
