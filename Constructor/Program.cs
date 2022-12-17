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
                student s = new student("Redwan", "Omer");
                Console.WriteLine("Your First Name is:{0}\n Your last name is:{1}",s.fname,s.lname);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
