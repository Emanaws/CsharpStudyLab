using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee("Redwan", "Omer", "Redwanomer44@gmail.com", 500000);
            FTE.getFullTimeEmployee();

            PartTimeEmployee PTE = new PartTimeEmployee("Nejat", "Omer", "Redwanomer44@gmail.com", 1000000);
            PTE.getPartTimeEmployee();
        }
    }
}
