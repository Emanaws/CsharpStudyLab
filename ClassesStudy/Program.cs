using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Customer C1 = new Customer("Redwan", "Omer", "Male");
          C1.PrintFullName();
          Customer C2 = new Customer("Nejat", "Hamza", "Female");
          C2.PrintFullName();
          Console.ReadLine();
        }
        
    }
}
