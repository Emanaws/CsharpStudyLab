using System;
using System.Text.RegularExpressions;
namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Phone numeber 615-555-5555
            /*
            string pattern = @"^(\d+)-(\d+)-(\d+)$";
            string input = "615-555-5555";
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                Console.WriteLine("phone number is vaild");
            }
            else 
            { 
                Console.WriteLine("no vailed phone number"); 
            }
            
            
            string pattern = @"^(\d+)-(\d+)-(\d+)$";
            //string pattern = @"^(\d{3})-(\d{3})-(\d{4})$";
            Console.WriteLine("please enter your phone number");
            string Userinput = Console.ReadLine().ToString();
            Match match = Regex.Match(Userinput, pattern);
            if (match.Success)
            {
                Console.WriteLine("phone number is vaild");
            }
            else
            {
                Console.WriteLine("no vailed phone number");
            }
            */
            /*
            // email address: alphanumericcharactors= 123---9 ,a-z or A-Z ,@ redwanomer44@gmail.com
            string pattern = @"^(\w+)@(\w+).([a-z]+)$";
            Console.WriteLine("Please enter your Email");
            string Userinput = Console.ReadLine().ToString();
            Match match = Regex.Match(Userinput, pattern);
            if (match.Success)
            {
                Console.WriteLine("valid Email address");
            }
            else
            {
                Console.WriteLine("not valid Email");
            }
            */  
            // validate ssn number: 123-36-2023
            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            Console.WriteLine("Please enter your SSN");
            string Userssn = Console.ReadLine().ToString();
            //string Userssn = "760-03-4719";
            //Match match = Regex.Match(pattern, Userssn);
            if (Regex.IsMatch(Userssn,pattern))
            {
                Console.WriteLine("valid SSN" +" " + Userssn);
            }
            else
            {
                Console.WriteLine("not valid SSN" + " " + Userssn);
            }
           //option 2
            Console.WriteLine("Please enter your SSN");
            string ssn = Console.ReadLine();
            if(Regex.IsMatch(ssn, @"^\d{3}-\d{2}-\d{4}$"))
            {
                Console.WriteLine("valid SSN" + " " + ssn);
            }
            else
            {
                Console.WriteLine("not valid SSN"+ " " + ssn);
            }
            Console.ReadLine();
        }
    }
}
