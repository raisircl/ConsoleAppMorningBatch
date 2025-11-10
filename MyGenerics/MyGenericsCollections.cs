//using ConsoleAppMorningBatch.Oops;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppMorningBatch.MyGenerics
//{
//    public class MyGenericsCollections
//    {
//        static void Main()
//        {
//            //declare a delegate

//            ArrayList al = new ArrayList();
//            al.Add(10);
//            al.Add("Hello");
//            al.Add(20.5);
//            foreach (var item in al)
//            {
//                Console.WriteLine(item);
//            }
//            Console.WriteLine("**********Generic Collection**********");
//            int counts = al.Count;

//            List<int> li = new List<int>();
//            li.Add(10);

//            List<string> li2 = new List<string>();
//            li2.Add("Hello Generic");

//            Dictionary<int, string> dict = new Dictionary<int, string>();
//            dict.Add(1, "One");
//            dict.Add(2, "Two");
//            foreach (var item in dict)
//            {
//                Console.WriteLine(item.Key + " " + item.Value);


//            }

//            SortedList<int, string> sl = new SortedList<int, string>();
//            sl.Add(3, "Three");
//            sl.Add(1, "One");
//            sl.Add(2, "Two");
//            foreach (var item in sl)
//            {
//                Console.WriteLine(item.Key + " " + item.Value);
//            }

//            HashSet<string> hs = new HashSet<string>();
//            hs.Add("Apple");
//            hs.Add("Banana");
//            hs.Add("Apple"); // Duplicate, will not be added
//            foreach (var item in hs)
//            {
//                Console.WriteLine(item);
//            }

//            Queue<int> queue = new Queue<int>();
//            queue.Enqueue(1);
//            queue.Enqueue(2);
//            queue.Enqueue(3);
//            while (queue.Count > 0)
//            {
//                Console.WriteLine(queue.Dequeue());
//            }
            
//            IList<Rect> rects = new List<Rect>();   
//            rects.Add(new Rect { Length = 10, Breadth = 20 });
//            rects.Add(new Rect { Length = 15, Breadth = 25 });  
//            foreach (var rect in rects)
//            {
//                Console.WriteLine($"Length: {rect.Length}, Breadth: {rect.Breadth}, Area: {rect.Area()}");
//            }
//            // Anonymous Method
//            /*
//             int x=10;
//             int *y=&x;
//             y is pointer to x  
//             y holding the address of x 
//             Q. can pointer hold the address of a function in c.
//                1. yes

//             in c# we have something called delegate
//             using delegate we can hold the address of a function
//             and we can pass a function as a parameter to another function
//             */

//        }

//    }
//}
