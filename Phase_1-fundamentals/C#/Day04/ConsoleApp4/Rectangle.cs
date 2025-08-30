using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Rectangle : Shape, IMovable, IResizable
    {
        public void Move()
        {
            Console.WriteLine("Moving the rectangle");
        }
        public void Resize()
        {
            Console.WriteLine("Resizing the rectangle");
        }
    }
}
