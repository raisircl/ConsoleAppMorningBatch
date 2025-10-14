//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppMorningBatch
//{
//    enum Digits
//    {
//        Zero = 0,
//        One = 1,
//        Two = 2,
//        Three = 3,
//        Four = 4,
//        Five = 5,
//        Six = 6,
//        Seven = 7,
//        Eight = 8,
//        Nine = 9
//    }
//    enum Tens
//    {
//        Ten = 10,
//        Twenty = 20,
//        Thirty = 30,
//        Forty = 40,
//        Fifty = 50,
//        Sixty = 60,
//        Seventy = 70,
//        Eighty = 80,
//        Ninety = 90
//    }
//    enum Elevens
//    { 
//        Eleven = 11,
//        Twelve = 12,
//        Thirteen = 13,
//        Fourteen = 14,
//        Fifteen = 15,
//        Sixteen = 16,
//        Seventeen = 17,
//        Eighteen = 18,
//        Nineteen = 19
//    }
//    enum Sepraters
//    {
//        Hundred=100,
//        Thouosand=1000,
//        Lakh = 100000,
//        Crore = 10000000
//    }
//internal class DigitToWorld
//    {
//        static void Main()
//        {
//            int num, digits=0,temp;
//            Console.WriteLine("Enter a Number ");
//            num = Convert.ToInt32(Console.ReadLine());
//            temp = num;
//            /*while(temp>0)
//            {
//                digits++;
//                temp = temp / 10;
//            }
//            Console.WriteLine($"Number: {num} has {digits} Digits");
//            */
//            digits=num.DigitCount();
            
//            Console.WriteLine($"Number: {num} has {digits} Digits");
            
//        }
//    }
//}
//// 524 -> Five Hundred Twenty Four