using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**/
            Student s = new Student();
            s._Fname = "Redwan";
            s._Lname = "Omer";
            s._Gender = "M";
            s._DOB = DateTime.Parse("12/12/2002");

            Console.WriteLine( s.getstudentInfo() +  "your age is:" + s.GetAge()); //call the Method here 
            Console.ReadKey();
            

            /*
            Student s = new Student("Redwan", "Omer", DateTime.Parse("12/12/2002"), "M","Redwan@test.com");
            s.getstudentInfo(); 
            */ 
        }
    }
}
