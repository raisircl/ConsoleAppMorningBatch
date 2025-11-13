using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.MyLINQPrograms
{
    class LinqProgram
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            //filetering even numbers using LINQ method syntax
            var evens = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even Numbers using LINQ Where:");
            foreach (var even in evens)
            {
                Console.WriteLine(even);
            }

            // Using LINQ to filter even numbers using Query syntax
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;
            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Using LINQ method syntax to get squares of numbers
            var squares = numbers.Select(num => num * num);
            Console.WriteLine("\nSquares of Numbers:");
            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }

        }

    }
}
