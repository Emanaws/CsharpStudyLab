using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    internal class Program
    {  
     static void Main(string[] args)
        {
            Person P = new Person();
            P.Fname = "Redwan";
            P.Lname = "Omer";
            P.GetFullName();

            Console.ReadLine();
        }
    }
}
