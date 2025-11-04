using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 oops - object oriented programming system
 It is a concept to understand the real world entities in terms of objects
 The languages which support oops are called object oriented programming languages
 
 eg: C#, Java, C++, Python
 oops paradigms
    
    1. Encapsulation: A process to wrap the data and methods into a single unit is called encapsulation
       1.1 What we wrap 
           i. Properties: Decide how an object look like
           ii. Methods: Decide what an object can do
           iii. Events: What type of an action taken by an object
           iv. Event Handler : A method which handles the event
       1.2 During encapsulation we will also decide which member of class should be public or private so 
           to make a member private is known as data hiding
    2. Abstraction: Represent the complexity in a simple way is called abstraction
       for example: Pink (color) - RGB ratio we do not know but we know the pink
    3. Inheritance: A process to acquire the properties and methods of a class into another class is called inheritance
       3.1 Types of inheritance
           i. Single level inheritance
           ii. Multi level inheritance
           iii. Hierarchical inheritance
           iv. Multiple inheritance (not supported in c#)
    4. Polymorphism: Many forms
       4.1 Types of polymorphism
           i. Compile time polymorphism (static binding) - Method overloading, Operator overloading
           ii. Run time polymorphism (dynamic binding) - Method overriding

    5. Class: It provides theoratical description about an object does not physicaly exist in the world.it is
         a blueprint for an object eg: Human Being, Car, Animal
    6. Object: Real life representative of a class. It is a physical entity. eg: Ram, Anita, BMW, Audi, Dog, Cat

 
 */
namespace ConsoleAppMorningBatch.Oops
{
    //public, private , protected, internal, protected internal, private protected
    //These are access specifiers or access modifiers: a class or its members can be accessed by other classes or members
    public class Rect: Quadrilateral, IShape
    {
        private int _length; // field or data member
        private int _breadth; // field or data member
                              //Property: It is a special type of method which is used to set or get the value of a field

        //constructor: A special type of method which has same name as of class name and  is used to initialize the object
        //it automatically invoked at the time of object creation
        //it called only once during the lifetime of an object
        //it can not be private
        
        //it has 4 types
            //1. default constructor - no argument constructor
            //2. parameterized constructor - with argument constructor
            //3. static constructor - used to initialize the static members of a class
            //4. copy constructor - used to create the duplicate object

        public Rect() // default constructor
        {
            Console.WriteLine("Rect default constructor called");       
            _length = 1;
            _breadth = 1;
        }
        public Rect(int l, int b):base(l,b,l,b) // parameterized constructor
        {
            // calling parent class parameterized constructor

            _length = l;
            _breadth = b;
        }
        public Rect(Rect r):base(r._length,r._breadth,r._length,r._breadth) // copy constructor
        {
            _length = r._length;
            _breadth = r._breadth;
        }
        //constructor overloading
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
        //only get section available in property is called read only property
        //only set section available in property is called write only property
        public int Breadth
        {
            get { return _breadth; }
            set { _breadth = value; }
        }
        public int Area() // method or member function
        {
            return _length * _breadth;
        }
        public Rect Add(Rect r)
        {
            // this is a pointer which points to current object
            Rect newRect =new Rect();
            newRect.Length = this.Length + r.Length;
            newRect.Breadth = this.Breadth + r.Breadth;
            return newRect;
        }
        //operator overloading
        public static Rect operator +(Rect r1, Rect r2)
        {
            Rect newRect = new Rect();
            newRect.Length = r1.Length + r2.Length;
            newRect.Breadth = r1.Breadth + r2.Breadth;
            return newRect;
        }
    }
}

/*
 * 
Assignment1: Create a class named Circle with the following specifications:
1. Private field: radius (double)
2. Public property: Radius (get and set)
3. Default constructor: Initializes radius to 1.0
4. Parameterized constructor: Accepts a double parameter to initialize radius
5. Copy constructor: Accepts another Circle object to initialize radius
6. Public method: Area() - Returns the area of the circle (use Math.PI for π)

Assignment2: Create a class named BankAccount with the following specifications:
1. Private fields: accountNumber (string), accountHolder (string), balance (double)
2. Public properties: AccountNumber (get), AccountHolder (get and set), Balance (get)
3. Parameterized constructor: Accepts accountNumber and accountHolder to initialize the respective fields and sets balance to 0.0
4. Public methods:
   - Deposit(double amount): Adds the specified amount to the balance.
   - Withdraw(double amount): Subtracts the specified amount from the balance if sufficient funds are available; otherwise, displays an error message.
   - DisplayAccountInfo(): Displays the account number, account holder, and current balance.

Assignment3: Create a class named Box with the following specifications:
1. Private fields: length (double), breadth (double), height (double)
2. Public properties: Length (get and set), Breadth (get and set), Height (get and set)
3. Default constructor: Initializes length, breadth, and height to 1.0
4. Parameterized constructor: Accepts three double parameters to initialize length, breadth, and height
5. Copy constructor: Accepts another Box object to initialize length, breadth, and height
6. Public method: Volume() - Returns the volume of the box (length * breadth * height)
7. Compare 2 boxes using operator overloading for '>' and '<' or == or != based on their volumes.

Tip: 
1. Relational Operator always return either true or false (bool)

2. if you defined < then its you must defined > also   


*/