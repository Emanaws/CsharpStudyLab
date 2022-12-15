using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.PFName = "Redwan";
            p.PLName = "Omer";
            p.Gender = "Male";
            p.PLDOB = DateTime.Parse("12/12/2002");

            Console.WriteLine("Your Full Name is:{0}" , p.PFName + " " + p.PLName + "\n" + "Your gender is:" + p.Gender + "\n" + "your Age is:" + p.GetAge());
            Console.ReadKey();
        }
    }
}
