using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch
{
    //function overloading - function has same name and accept different parameters
    public class Shape
    {
        public void Area(int l, int b)
        {
            int a;
            a = l * b;
            Console.WriteLine($"Area of Rectangle is {a}");
        }
        public void Area(int side)
        {
            int a;
            a = side * side;
            Console.WriteLine($"Area of Square is {a}");
        }
        public void Area(double r)
        {
            double a;
            a = 3.14 * r * r;
            Console.WriteLine($"Area of Circle is {a}");
        }
    }
}
