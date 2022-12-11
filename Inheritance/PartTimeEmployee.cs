using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class PartTimeEmployee:Employee
    {
        public float _HourlySalary;

        public PartTimeEmployee(string FirstName, string LastName, string Email, float HourlySalary)
        {
          _FirstName = FirstName;
          _LastName = LastName;
          _Email = Email;
          _HourlySalary = HourlySalary;
        }
        public void getPartTimeEmployee()
        {
            Console.WriteLine("Full Time Employee is: = {0}", _FirstName + " " + _LastName + "\n" + "Your Email is:" + _Email + " \n" + "Your Salary is: " + _HourlySalary);
            //Console.WriteLine("Full Name: = {0}", _FName + " " + _LName + " \n" + "Your Gender is:" + _gender);
        }
    }
}
