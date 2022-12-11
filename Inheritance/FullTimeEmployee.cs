using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class FullTimeEmployee:Employee
    {
        public float _YearlySalary;

        public FullTimeEmployee(string FirstName, string LastName, string Email, float YearlySalary)
        {
          _FirstName = FirstName;
          _LastName = LastName;
          _Email = Email;
          _YearlySalary = YearlySalary;

           
        }
        public void getFullTimeEmployee()
        {
            Console.WriteLine("Full Time Employee is: = {0}", _FirstName + " "+ _LastName +"\n"+"Your Email is:" + _Email + " \n" + "Your Salary is: "+ _YearlySalary);
            //Console.WriteLine("Full Name: = {0}", _FName + " " + _LName + " \n" + "Your Gender is:" + _gender);
        }
    }
}
