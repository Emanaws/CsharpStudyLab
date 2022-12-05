using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStudy
{
        /*Classes
          class can be defined by using the class keyword
          A class can have one or more fields.
          A class can contain one or more constructors, fields, methods, properties, delegates, and events.
          A class and its members can have access modifiers such as public, private, protected and internal.
        */
    internal class Customer
    {
        string _FName;
        string _LName;

        /* Constructor
         A constructor is a special type of method which will be called automatically 
         when you create an instance of a class. A constructor is defined by using an access modifier and class name
         <access-modifier> <class-name>(){ }.

         the purpose of a class constructor is to initialize class fields. 
         A class constructor is automatically called when an instance is created.

         constructor do not have return values and always have the same names as the class.
         A constructor can be public, private, or protected.
         
         constructor are not mandatory. if we dont provide a constructor, 
         a defualt parameter less constructor is automatically provided.
         
         */
        //con
        public Customer(string fName, string lName)
        {
            _FName = fName;
            _LName = lName;
            /* Or
            this._FName = fName;
            this._LName = lName;
            */
        }
            /*Distructors
             Distructors have the same name as the class with ~symbol in front of them
             Distructors are places where you could put your code to release any resources your class was holding during lifetime
          
             They are called garbage collector
             */
        ~Customer()
        {
            //clean up code here
        }
        public void PrintFullName()
        {
            Console.WriteLine("Full Name: = {0}", _FName + " " + _LName);
            Console.WriteLine("Full Name: = {0}", this._FName + " " + this._LName);
        }
    }
}
