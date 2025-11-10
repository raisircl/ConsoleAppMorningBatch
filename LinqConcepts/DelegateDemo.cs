//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppMorningBatch.LinqConcepts
//{
//    public class DelegateDemo
//    {
//        //declaring a delegate
//        public delegate void Print(int value);
//        static void Main()
//        {

//            //PrintHelper(PrintNumber,1234567);
//            //PrintHelper(PrintMoney, 5000);
            
            
//            //multicast delegate    
//            Print print = PrintNumber;
//            print += PrintMoney;
//            print += PrintAge;

//            //print -= PrintMoney;

//            print(25);

//            //anonymous method  
//            Print print1 = delegate (int num)
//            {
//                Console.WriteLine("Anonymous Method: {0}", num);
//            };
//            PrintHelper(print1, 789);
//        }
//        static void PrintNumber(int num)
//        {
//            Console.WriteLine("Comma Seprated Number: {0,-12:N0}",num);
//        }   
//        static void PrintMoney(int money)
//        {
//            Console.WriteLine("Money: {0:C}", money);
//        }
//        static void PrintAge(int age)
//        {
//            Console.WriteLine("Age: {0}", age);
//        }   
//        static void PrintHelper(Print printdel,int value)
//        {
//            printdel(value);
//        }
//    }
//}
