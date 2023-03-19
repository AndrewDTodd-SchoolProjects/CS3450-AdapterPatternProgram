using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class XXCircle
    {
        public void setLocation()
        {
            Console.WriteLine($"Setting location of XXCircle object");
        }
        public void getLocation()
        {
            Console.WriteLine($"Getting location of XXCircle object");
        }
        public void displayIt()
        {
            Console.WriteLine($"Displaying XXCircle object");
        }
        public void fillIt()
        {
            Console.WriteLine($"Filling XXCircle object");
        }
        public void setItsColor()
        {
            Console.WriteLine($"Setting color of XXCircle object");
        }
        public void undisplayIt()
        {
            Console.WriteLine($"Undisplaying XXCircle object");
        }
    }
}
