using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.Oops
{
    public class Student
    {
        public int RollNo { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public Address? PermanentAddress { get; set; }
        public Address? CurrentAddress { get; set; }
    }

    public class Address
    {
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
    }
}
