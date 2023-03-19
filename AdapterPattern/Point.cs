using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Point : IShape
    {
        public void display()
        {
            Console.WriteLine($"Displaying point");
        }
        public void fill()
        {
            Console.WriteLine($"Filling point. Whatever that means.");
        }
        public void undisplay()
        {
            Console.WriteLine($"Undiplaying point");
        }
    }
}
