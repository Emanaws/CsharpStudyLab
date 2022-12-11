using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Persons
    {
        
        public string  _FName { get; set; }
        public string  _LName { get; set; }
        string _ssn;

        public Persons ( string fName, string lName, string ssn)
        {
            
            _FName = fName;
            _LName = lName;
            _ssn = ssn;
        }

        public void getPersonInfo()
        {
            Console.WriteLine("PersonInfo: {0}" ,  _FName  + " " +  _LName  + " "+ _ssn);
            Console.WriteLine("PersonInfo: {0}" , this._FName + " " + this._LName + " " + this._ssn);
        }
    }
}
