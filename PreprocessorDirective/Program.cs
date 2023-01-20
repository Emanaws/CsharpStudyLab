#define Redwan
#undef _Redwan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PreprocessorDirective
{
    internal class Program
    {
    static void Main(string[] args)
   {
            /*
              #if (Redwan)
                 Console.WriteLine("Redwan Exists");
              #elif (_Redwan)
              Console.WriteLine("_Redwan Exists")
              #else
              #warning "Not found"
              #error "Check use of preprocessors"
              #endif
            */
            #region "This is to validate fname"
            string fname = "redwan";
            //Console.WriteLine("Please Enter your fname");
            if (fname == "redwan" || fname == "Redwan")
                Console.WriteLine("value for fname is 'redwan'");
            else
                Console.WriteLine("Value of ch is unknown");
            #endregion

            Console.ReadLine();
        }
    }
}
