using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal interface IShape
    {
        public virtual void setLocation()
        {
            Console.WriteLine($"Setting location");
        }
        public virtual void getLocation()
        {
            Console.WriteLine($"Getting location");
        }
        public abstract void display();
        public abstract void fill();
        public virtual void setColor()
        {
            Console.WriteLine($"Setting color");
        }
        public abstract void undisplay();
    }
}
