using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.Oops
{
    public class Square:Rect
    {
        int _side; // field or data member
        public Square() : base() // default constructor
        {
            Console.WriteLine("Square default constructor called");
            _side = 1;
        }
        public Square(int s) : base(s, s) // parameterized constructor
        {
            _side = s;
        }
        public Square(Square s) : base(s.Side, s.Side) // copy constructor
        {
            _side = s._side;
        }
        public int Side
        {
            get { return _side; }
            set
            {
                _side = value;
              
            }
        }
        
    }
}
