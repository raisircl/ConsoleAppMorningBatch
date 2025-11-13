using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppMorningBatch.Oops;
namespace ConsoleAppMorningBatch.MyLINQPrograms
{
    public class StudentProgram
    {
        static void Main()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { RollNo=1,Name="Alice",Age=15,CurrentAddress=new Address(){AddressLine1="#101, StreetNo 1", AddressLine2="Near Bus Stand",City="Sirsa",State="Haryana",Country="India"}},
                new Student() { RollNo=2,Name="Bob",Age=25,CurrentAddress=new Address(){AddressLine1="#102, StreetNo 2", AddressLine2="Near Park",City="Delhi",State="Delhi",Country="India"}},
                new Student() { RollNo=3,Name="Charlie",Age=17,CurrentAddress=new Address(){AddressLine1="#103, StreetNo 3", AddressLine2="Near School",City="Mumbai",State="Maharashtra",Country="India"}},
                new Student() { RollNo=4,Name="David",Age=22,CurrentAddress=new Address(){AddressLine1="#104, StreetNo 4", AddressLine2="Near College",City="Bangalore",State="Karnataka",Country="India"}},
                new Student() { RollNo=5,Name="Eve",Age=19,CurrentAddress=new Address(){AddressLine1="#105, StreetNo 5", AddressLine2="Near Hospital",City="Chennai",State="Tamil Nadu",Country="India"}}
            };
            // Using LINQ query syntax to find teenage students
            var teenStudentsQuery = from student in studentList
                                    where student.Age >= 12 && student.Age <= 20
                                    select student;
            Console.WriteLine("Teenage Students (Query Syntax):");
            foreach (var teen in teenStudentsQuery)
            {
                Console.WriteLine(teen.Name);
            }
            // Using LINQ method syntax to find teenage students
            var teenStudentsMethod = studentList.Where(s => s.Age >= 12 && s.Age <= 20).ToList();
            Console.WriteLine("\nTeenage Students (Method Syntax):");
            foreach (var teen in teenStudentsMethod)
            {
                Console.WriteLine(teen.Name);
            }
            //filter those student whose state is "Haryana" 
            var haryanaStudents = from student in studentList
                                  where student.CurrentAddress != null && student.CurrentAddress.State == "Haryana"
                                  select student;
            Console.WriteLine("\nStudents from Haryana:");
            foreach (var student in haryanaStudents)
            {
                Console.WriteLine(student.Name);
            }
            // Using LINQ method syntax to filter students from Haryana
            var haryanaStudentsMethod = studentList
                                        .Where(s => s.CurrentAddress != null && s.CurrentAddress.State == "Haryana")
                                        .ToList();
        }
    }
}
