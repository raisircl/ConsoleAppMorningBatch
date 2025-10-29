using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.Oops
{
    public class Quadrilateral
    {
        private int _side1; // field or data member
        private int _side2; // field or data member
        private int _side3; // field or data member
        private int _side4; // field or data member
        public Quadrilateral() // default constructor
        {
            Console.WriteLine("Quadrilateral default constructor called before rect constrcutor");  
            _side1 = 1;
            _side2 = 1;
            _side3 = 1;
            _side4 = 1;
        }
        public Quadrilateral(int s1, int s2, int s3, int s4) // parameterized constructor
        {
            _side1 = s1;
            _side2 = s2;
            _side3 = s3;
            _side4 = s4;
        }
        public Quadrilateral(Quadrilateral q) // copy constructor
        {
            _side1 = q._side1;
            _side2 = q._side2;
            _side3 = q._side3;
            _side4 = q._side4;
        }
        public int Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }
        public int Side2
        {
            get { return _side2; }
            set { _side2 = value; }
        }
        public int Side3
        {
            get { return _side3; }
            set { _side3 = value; }
        }
        public int Side4
        {
            get { return _side4; }
            set { _side4 = value; }
        }
        public int Perimeter() // method or member function
        {
            return _side1 + _side2 + _side3 + _side4;
        }
    }
}
