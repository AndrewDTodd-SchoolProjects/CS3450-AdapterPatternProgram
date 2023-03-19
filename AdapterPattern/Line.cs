using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Line : IShape
    {
        public void display()
        {
            Console.WriteLine($"Displaying line");
        }
        public void fill()
        {
            Console.WriteLine("Filling line. Whatever that means.");
        }
        public void undisplay()
        {
            Console.WriteLine($"Undisplaying line");
        }
    }
}
