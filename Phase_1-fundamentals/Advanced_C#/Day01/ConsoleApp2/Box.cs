using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Box<T>
    {
        public T Item { get; set; }

        public void ShowInfo()
        {
            dynamic obj = Item;

            Console.WriteLine($"Name: {obj.Name}, Price: {obj.Price}");
        }
    }
}
