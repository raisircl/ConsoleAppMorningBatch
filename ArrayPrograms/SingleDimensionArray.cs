//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppMorningBatch.ArrayPrograms
//{
//    internal class SingleDimensionArray
//    {
//        static void Main()
//        {
//            int[] a=new int[5]; //declaration and instantiation

//            int[] b = { 10, 20, 30, 40, 50 }; //declaration, instantiation and initialization

//            int i;
//            for (i = 0; i < 5; i++)
//            {
//                Console.WriteLine($"Enter element {i + 1}: ");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
            
//            Console.WriteLine("Elements in array a are: ");
//            for (i = 0; i < 5; i++)
//            {
//                Console.WriteLine(a[i]);
//            }

//            //foreach loop  : it works only with collection
//            Console.WriteLine("Elements in array b are: ");
//            foreach (int k in b)
//            {
//                Console.WriteLine(k);
//            }
//        }
//    }
//}
