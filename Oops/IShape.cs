using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.Oops
{
    //What is Interface?
    //Ans: Interface is a blueprint of a class. It contains only the declaration of the members.
    //Or it is also known as pure abstract unit because it contains only abstract members.
    //abtract members are the members which do not have any body.
    //it sign an agreement with class if a class implement an interface then it is mandatory
    /// <summary>
    /// /for that class to provide the implementation of all the members of that interface.
    /// </summary>
    /// if a class does not provide the implementation of all the members of that interface
    /// we can not create the object of that class.
    /// in c++ this concept is known as pure virtual function.
    /// intrface helps to achieve the multiple inheritance in c# because c# does not support
    /// interface help the programmers to work together on the same project.
    /// Sr. Developer meet with client and gather all the requirements and create the interfaces
    /// Jr. Developer implement those interfaces.
    public interface IShape
    {
        public int Area(); // abstract method  
    }
}
