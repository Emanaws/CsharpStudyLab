using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec
{
    internal class Student
    {
        public string _Fname { get; set; }
        public string _Lname { get; set; }
        public DateTime _DOB { get; set; }
        public string _Gender { get; set; }
       
        public string _Email { get; set; }


        //public Student()
        //{
        //    //your code here(Optional)
        //}

        //public Student(string fname, string lname, DateTime DOB, string gender, string email)
        //{
        //    _Fname = fname;
        //    _Lname = lname;
        //    _DOB = DOB;
        //    _Gender = gender;
        //    _Email = email;
        //}
        public string getstudentInfo()
        //public void getstudentInfo()
        {
            return this._Fname + " " + this._Lname + " " + this._Gender + " " + this._DOB + " ";
            //Console.WriteLine("Student Information: {0} " ,this._Fname + " " + this._Lname + " " + this._Gender + " " + this._DOB);
            //Console.ReadLine();
        }
        public int GetAge()//calculate age here below
        {
            var dob =_DOB.Year;
            var thisyear = DateTime.Now.Year;
            return thisyear - dob;
        }
    }
}
