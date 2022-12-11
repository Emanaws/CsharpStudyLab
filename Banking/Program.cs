using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account accnt = new Account();
            //Account accnt2 = accnt;
            //Account accnt3 = accnt;
            Persons p = new Persons( "Redwan", "Omer","123-34-4578");
            p.getPersonInfo();
            
        }
    }
}
