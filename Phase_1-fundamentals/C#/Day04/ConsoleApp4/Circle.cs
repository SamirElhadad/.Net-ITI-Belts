using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Circle : Shape , IMovable, IResizable
    {
        public void Move()
        {
            Console.WriteLine("Moving the circle");
        }
        public void Resize()
        {
            Console.WriteLine("Resizing the circle");
        }
    }
    
}
