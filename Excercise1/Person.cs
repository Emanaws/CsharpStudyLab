using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    internal class Person
    {
        public string Fname;
        public string Lname;


        public void GetFullName()
        {
            Console.WriteLine("My Name is {0}", Fname + " " + Lname);
        }
    }
    
}
