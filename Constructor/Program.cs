using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                #region with out constructor
                student s = new student("Redwan", "Omer");
                Console.WriteLine("Your First Name is:{0}\nYour last name is:{1}", s.fname, s.lname);
                Console.ReadLine();
                #endregion
                #region With constructor:
                //With constructor:
                Department d = new Department(12, "Civil Engineering");               
                Console.WriteLine("Your Department Id is:{0}\nYour Department Name is:{1}", d.departmentId, d.departmentName);
                Console.ReadLine();
                #endregion
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
