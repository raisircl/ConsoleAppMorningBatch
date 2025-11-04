using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.Oops
{
    public class Box:IShape
    {
        private int _length; // field or data member
        private int _breadth; // field or data member
        private int _height; // field or data member
        public Box() // default constructor
        {
            _length = 1;
            _breadth = 1;
            _height = 1;
        }
        public Box(int l, int b, int h) // parameterized constructor
        {
            _length = l;
            _breadth = b;
            _height = h;
        }
        public Box(Box b) // copy constructor
        {
            _length = b._length;
            _breadth = b._breadth;
            _height = b._height;
        }
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
        public int Breadth
        {
            get { return _breadth; }
            set { _breadth = value; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public int Volume() // method or member function
        {
            return _length * _breadth * _height;
        }

        public int Area()
        {
           return _length*_breadth;
        }

        public static bool operator==(Box b1, Box b2)
        {
            return b1.Volume() == b2.Volume();    
        }
        public static bool operator !=(Box b1, Box b2)
        {
            return b1.Volume() == b2.Volume();
        }

    }
}
