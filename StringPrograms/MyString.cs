//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppMorningBatch.StringPrograms
//{
//    internal class MyString
//    {
//        static void Main()
//        {
//            string fname= "Yogi";
//            string lname = "Yoge";
//            string fullname;
//            fullname = string.Concat(fname, " ", lname);

//            Console.WriteLine(fullname);

//            if(string.Equals(fname, lname))
//            {
//                Console.WriteLine("Both are equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are not equal");
//            }

//            int x=string.Compare(fname, lname);
//            Console.WriteLine(x);

//            string name= string.Format("First Name: {0}, Last Name: {1}", fname, lname);

//            Console.WriteLine(name.ToLower());
//            Console.WriteLine(name.ToUpper());
//            Console.WriteLine(name.Length);
            
//            int pos=name.IndexOf("Name");
//            Console.WriteLine(pos);
//            name=name.Replace("Yogi", "Yogesh");
//            Console.WriteLine(name.ToLower());

//           string substr=fullname.Substring(0, 2);
//           Console.WriteLine(substr);
           
//           string names = "anil,jatin,MoHan,kamaL,suresh,Ankita";
//           string[] arr = names.Split(',');
//           foreach(string n in arr)
//            {
//                Console.WriteLine(n.ToProper());
//            }
           
//        }
//    }
//}
