using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class XXCircleIShape : IShape
    {
        private readonly XXCircle _xxCircle = new();

        public XXCircle XXCircle { get => _xxCircle; }

        void IShape.setLocation()
        {
            _xxCircle.setLocation();
        }
        void IShape.getLocation()
        {
            _xxCircle.getLocation();
        }
        public void display()
        {
            _xxCircle.displayIt();
        }
        public void fill()
        {
            _xxCircle.fillIt();
        }
        void IShape.setColor()
        {
            _xxCircle.setItsColor();
        }
        public void undisplay()
        {
            _xxCircle.undisplayIt();
        }
    }
}
