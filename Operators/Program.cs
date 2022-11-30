using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        /*
         1. Assignment Operator like =
         2. Arithmetic Operators like +,-,*,/,%
         3. Comparision Operators like ==,!=,>,>=,<,<=
         4. Conditional Operators like &&,||
         5. Ternary Operator like ?:
         6. Null Coalescing Operator ??
        */
        {
            /*Assignment Operator-allow assigning values to variables.
            int N = 10;
            bool b = true;
            Console.WriteLine(b)
            */

            /*Arithmetic Operators they are used to perform simple mathematical operations.
            int Numerator = 50;
            int Denominator = 5;
            int result = Numerator/Denominator;
            Console.WriteLine("Result = {0}", result);
            */
            /*Conditional Operators – operators that work with Boolean data types and Boolean expressions.
            int num1 = 10;
            int num2 = 21;
            if (num1 == 10 || num2 == 20)
            {
                Console.WriteLine("Hello world");
            }
            */
            /*Ternary Operator
            int Num = 15;
            bool IsNumfive;

            if (Num == 5)
            {
                IsNumfive = true;
            }
            else
            {
                IsNumfive = false;
            }*/
           /* Methode2
            int Num = 15;
             bool IsNumfive = Num == 5 ? true : false;
            Console.WriteLine("Your Number == 5 is {0}" , IsNumfive);
           */
            Console.ReadLine();
        }
        
    }
}
