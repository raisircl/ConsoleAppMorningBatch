using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.Oops
{
    class Program
    {
        static void Main()
        {
            Rect r1 = new Rect();
            
            Rect r2 = new Rect();   

            Rect r3=new Rect(30, 40); // parameterized constructor  
            
            Rect r4 = new Rect(r3); // copy constructor

            r1.Length = 10; // set
            r1.Breadth = 20; // set
            Console.WriteLine($"Dimension of Rect1 is {r1.Length}x{r1.Breadth}"); // get
            Console.WriteLine($"Dimension of Rect2 is {r2.Length}x{r2.Breadth}"); // get
            Console.WriteLine($"Dimension of Rect3 is {r3.Length}x{r3.Breadth}"); // get
            Console.WriteLine($"Dimension of Rect4 is {r4.Length}x{r4.Breadth}"); // get

            int a = r1.Area();
            Console.WriteLine($"Area of Rect is {a}");
        }
    }
}
