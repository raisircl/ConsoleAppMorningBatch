//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppMorningBatch.MyGeneralOperations
//{
//    /*
//     Function Calling Method - 
//        1. Call By Value - if any change in formal argument it will not reflect in actual argument
//        2. Call By Reference - if any change in formal argument it will reflect in actual argument
//        3. Call By Out - it is used to return multiple values from a method

//     */
//    internal class Swaping
//    {
//        static void Main()
//        {
//            int n1, n2;
//            Console.WriteLine("enter N1");
//            n1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter N2");
//            n2 = Convert.ToInt32(Console.ReadLine());
            
//            Console.WriteLine($"Before Swapping in Main - n1: {n1} and n2: {n2}");
            
//            SwapByRef(ref n1, ref n2); // n1 and n2 is actual argument

//            Console.WriteLine($"After Swapping in Main - n1: {n1} and n2: {n2}");

//            int t;
//            float p;
//            Result(90, 80, 70, 60, 50, out t, out p);
//            Console.WriteLine($"Total: {t} and Percentage: {p}");

//        }
//        // Call By Value
//        static void SwapByValue(int a, int b) // a and b is formal argument
//        {
//            int temp = a;
//            a = b;
//            b = temp;
//            //Console.WriteLine("After Swapping in Method - a: " + a + " b: " + b);
//        }
//        // Call By Reference
//        static void SwapByRef(ref int a, ref int b) // a and b is formal argument
//        {
//            int temp = a;
//            a = b;
//            b = temp;
//            //Console.WriteLine("After Swapping in Method - a: " + a + " b: " + b);
//        }
//        static void Result(int h, int e, int m, int sci, int sst, out int total, out float per) // a and b is formal argument
//        {
//            // in call by out we must initialize the out parameter before using it
//            //in call by out formal argument does not has value of actual argument
//            total = h + e + m + sci + sst;
//            per = total / 5.0f;
//        }
//    }
//}
