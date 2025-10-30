using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMorningBatch.Oops
{
    //function overriding - run time polymorphism - dynamic binding - overriding the base class method in derived class
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
        public void Fetch()
        {
            Console.WriteLine("Dog fetches the ball");
        }
    }
    public class Cat : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }
    public class Lion: Cat
    {
        public void Speak()
        {
            Console.WriteLine("Lion roars");
        }
    }
    public class Woolf : Dog
    {
        public void Speak()
        {
            Console.WriteLine("Woof howls");
        }
    }
}
