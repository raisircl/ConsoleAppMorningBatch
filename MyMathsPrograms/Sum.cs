using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.MyMathsPrograms
{
    /*
 * Assembly - Intermidiate Language Code
 *  1. C# Code -> Compile -> IL Code -> JIT Compiler -> Machine Code
 *  Two Types of Assembly (IL Code)
 *      1. Exe - Executable - Out Process Service
 *          Can Independently run
 *          UI
 *      2. Dll - Dynamic Link Library - In Process Service
 *          Invoke by Exe or Dll
 *          DLL does not UI
 *  In this Project 
 *  
 *  Assembly Name : ConsoleAppMorningBatch
 *            Type: Exe
 *                  
 *                  System used by ConsoleAppMorningBatch (Exe)
 *                  DLL
 *  Namespace : It is a logical name which is given to set of classes
 *              It is just like as a folder in file system
 *              every assembly contains atleast one namespace 
 *              thats name is same as assembly name
*/
    namespace ConsoleAppMorningBatch
    {
        internal class Sum
        {
            //Console class exist in System namespace
            static void Main()
            {
                int n1, n2, total;
                Console.WriteLine("Enter First Number");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                n2 = Convert.ToInt32(Console.ReadLine());
                total = n1 + n2;
                Console.WriteLine($"The Sum is {total}");

            }
        }
    }
}