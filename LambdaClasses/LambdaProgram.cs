using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.LambdaClasses
{
    public class LambdaProgram
    {
         
        static void Main()
        {
            //var IsTeenAger = delegate (Student student) { return student.Age >= 12 && student.Age <= 20; };

            Func<Student, bool> IsTeenAger = student =>
            {
                return student.Age >= 12 && student.Age <= 20;
            };

            Student s1 =new Student() { RollNo=1,Name="Alice",Age=15};
            Student s2 = new Student();
            s2.RollNo = 2;
            s2.Name = "Bob";
            s2.Age = 25;
            if(IsTeenAger(s2))
            {
                Console.WriteLine($"{s1.Name} is a Teenager");
            }
            else
            {
                Console.WriteLine($"{s1.Name} is not a Teenager");
            }
            // Lambda Expression    

        }
    }
    public class Student
    {
        public int RollNo { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
