using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Rectangle : IShape
    {
        public void display()
        {
            Console.WriteLine($"Displaying rectangle");
        }
        public void fill()
        {
            Console.WriteLine($"Filling rectangle... rectangle now filled");
        }
        public void undisplay()
        {
            Console.WriteLine($"Undisplaying rectangle");
        }
    }
}
