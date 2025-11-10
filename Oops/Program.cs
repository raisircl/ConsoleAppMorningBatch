//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppMorningBatch.Oops
//{
//    class Program
//    {
//        static void Main()
//        {
//            //Rect r1 = new Rect();
//            //Rect r2 = new Rect(30, 40); // parameterized constructor  

//            //Rect r3 = new Rect();
//            //Rect r4 = new Rect(r3); // copy constructor

//            //r1.Length = 10; // set
//            //r1.Breadth = 20; // set

//            //r3 = r1 + r2; // operator overloading

//            ////r3 =r1.Add(r2);  // current object is r1 and r2 is passed as argument
//            ////this will represent r1 inside Add method of Rect class
//            ////and r will represent r2 inside Add method of Rect class

//            //Console.WriteLine($"Dimension of Rect1 is {r1.Length}x{r1.Breadth}"); // get
//            //Console.WriteLine($"Dimension of Rect2 is {r2.Length}x{r2.Breadth}"); // get
//            //Console.WriteLine($"Dimension of Rect3 is {r3.Length}x{r3.Breadth}"); // get
//            //Console.WriteLine($"Dimension of Rect4 is {r4.Length}x{r4.Breadth}"); // get

//            //int a = r1.Area();
//            //Console.WriteLine($"Area of Rect is {a}");

//            //Shape s1 = new Shape();

//            ////connection of function a function call with its body is called data binding
//            //s1.Area(10,20); // Rectangle 
//            //s1.Area(5); // Square   
//            //s1.Area(7.5); // Circle

//            //Box b1 = new Box(10, 20, 30);
//            //Box b2 = new Box(5, 15, 40);
//            //if (b1 == b2)
//            //{
//            //    Console.WriteLine("Boxes are equal in volume");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("Boxes are not equal in volume");
//            //}

//            //Rect rect = new Rect(); //default constructor   

//            //int p= rect.Perimeter(); // calling inherited method   
//            //Console.WriteLine($"Perimeter of Rect is {p}");

//            //Rect rect2 = new Rect(15, 25); // parameterized constructor 
//            //int p1= rect2.Perimeter();
//            //Console.WriteLine($"Perimeter of Rect2 is {p1}");

//            //Square sq = new Square(5); // default constructor    
//            //int sp = sq.Perimeter(); // calling inherited method    
//            //Console.WriteLine($"Perimeter of Square is {sp}");
//            //int sarea = sq.Area(); // calling own method    
//            //Console.WriteLine($"Area of Square is {sarea}");
//            Animal a = new Animal();
//            a.Speak(); // Animal speaks
            
//            Animal d = new Dog(); // in oops base class ref variable can take the ref of derive class object
//                                  // and can access only the base class members
//            d.Speak();

//        }
//    }
//}
