using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch
{
    public static class MyExtensions
    {
        public static int DigitCount(this int num)
        {
            return num.ToString().Length;   
        }
        public static string ToWord(this int num)
        {
            return num.ToString();
        }
    }
}
