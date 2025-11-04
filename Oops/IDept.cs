using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.Oops
{
    public interface IDept
    {
        public void GetAllDept(); // abstract method
        public void ShowDeptDetails(); // abstract method
        public void UpdateDeptDetails();
        public void DeleteDeptDetails();
        public void AddDeptDetails();

    }
}
