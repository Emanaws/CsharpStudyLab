using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForEach
{
    internal class Program
    {
        //int num1;
        //int num2;
        //int result;
        static void Main(string[] args)
        {
            /*
             Write a C# Sharp program that takes a number and a width also a number, as input and then displays 
            a triangle of that width, using that number.
            
          Console.WriteLine("Please Provide Your Number");
            int N = int.Parse(Console.ReadLine());
            int c = 1;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(c + " ");
                    c++;
                }*/
            /*--------------------------
            int N = int.Parse(Console.ReadLine());
            int c = 1;
            for (int i = N; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(c + " ");
                        c++;
                    }
                    Console.WriteLine();
                 }
            */
            /*
             Write a C# Sharp program that takes two numbers as input and perform an 
            operation (+,-,*,x,/) on them and displays the result of that operation
             
            int Num = 50;
            int Deno = 5;
            int result = Num - Deno;
            Console.WriteLine("Result = {0}", result);
           */

            //Console.WriteLine("Please Enter Your first Number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Enter Your second Number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Select Operator");
            //Console.WriteLine("1.Addition");
            //Console.WriteLine("2.Multplication");
            //Console.WriteLine("3.Substraction");
            //Console.WriteLine("4.Divide");


            /*
            Write a C# Sharp program that takes the radius of a circle as input and 
            calculate the perimeter and area of the circle.
            PI= 3.14
             
            Console.WriteLine("Enter Radious: ");
            double Radious = Convert.ToDouble(Console.ReadLine());
            double A = Math.PI * Radious * Radious;
            //double A = (3.14) * Radious * Radious;
            Console.WriteLine("Area of circle: " + A);
            */
            /*
             Write a C# Sharp program that takes distance and time as input and displays the speed in 
             kilometres per hour and miles per hour
            
            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Input distance(metres): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Your speed in metres/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
            */

            /*
             Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, 
             a digit, or any other symbol.
           

            char symbol;
            Console.Write("Enter your symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());
            if((symbol == 'a') || (symbol == 'e') || (symbol=='i') || (symbol=='o') || (symbol=='u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");
           */
            /*
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + ", ");
            }*/

            /* Write a program to revert your name
            
            // original string
            string str = "Redwan Omer";
            // reverse the string
            string red = string.Join(" ", str.Split(' ').Select(s => new String(s.Reverse().ToArray())));
            Console.WriteLine(red);
            */
            /*Write a program to convert your name into upper case
             Option1
                    string str; 
                    Console.WriteLine("Please Enter Your Name");
                    str = Console.ReadLine().ToString();
                    string upperstr = str.ToUpper();
                     Console.Write("Converted string is: " + upperstr);
           
            //Option2
                    string str;
                    Console.WriteLine("Please Enter Your Name");
                    str = Console.ReadLine().ToString();
                    Console.WriteLine("Converted string is: " +  str.ToUpper()); 
            
                    Console.WriteLine("please enter your name");
                    string str = Console.ReadLine().ToString();
                    string result = str.Substring(0, 1).ToUpper() + str.Substring(1);
                    Console.WriteLine(result);
            */

            /*
             Write a program to access age of student and categorize as followes:            
                    If age is <=12 kid 
                    If age >=13 and <=19 teen 
                    If age >19 adult 
             
                    Console.WriteLine("Please Enter your age");
                    int UserAge = int.Parse(Console.ReadLine());
                    if (UserAge <= 12)
                    {
                        Console.WriteLine("Kid");
                    }
                    else if (UserAge >= 13 && UserAge <= 19)
                    {
                        Console.WriteLine("Teen");
                    }
                    else if  (UserAge > 19)
                    {
                        Console.WriteLine("Adult");
                    }
            */
            /*
             Write a program to accept gender in single character as M or F and display in full as Female or Male
            
                    Console.WriteLine("Please Enter Your Gender First Charactor");
                     string gender = Console.ReadLine().ToString().ToUpper();
                    if(gender == "M")
                    {
                             Console.WriteLine("Male");
                    }
                    else if (gender == "F") 
                    {
                            Console.WriteLine("Female");
                     }
                    else 
                      {
                            Console.WriteLine("Please Enter Your correct gender Charactor");                
                      } 
              Option2

                Console.WriteLine("Please Enter Your Gender First Charactor");
                string gender = Console.ReadLine().ToUpper();
                if(gender !="M" && gender != "F")
                {
                    Console.WriteLine("Please Enter Your correct gender Charactor");
                }
                else if(gender == "F")
                {
                    Console.WriteLine("Female");
                }
                else if(gender == "M")
                {
                    Console.WriteLine("Male");
                } 
               */
            /*Write a program to count number of characters in your name
                    Console.WriteLine("Please Enter your Name");
                    string UserName = Console.ReadLine().ToString();
                    int count = 0;
                    for (int i = 0; i < UserName.Length;i++)
                    {
                           // if (UserName[i] != ' ') 
                            count++;
                             //count = i+1;
                   }
                    Console.WriteLine(UserName + " "  + count);
            */
           /* //Write a program to check if the number is prime or not

                    Console.WriteLine("Please Enter your Number");
                    int userInput = int.Parse(Console.ReadLine());
                    if (userInput <= 1)
                    {
                        Console.WriteLine("Try again");
                    }
                    else
                    {
                        int num = 0;
                        for (int i = 2; i < userInput; i++)
                        {
                            if (userInput % 1 == 0)
                            {
                                Console.WriteLine("{0} is not Prime", userInput);
                                num = 1;
                                break;
                            }
                        }
                        if (num == 0)
                        {
                            Console.WriteLine("{0} is Prime", userInput);
                        }
                    }
            Option2
                        Console.WriteLine("Enter a number to check if it's a Prime or not");
                        int a = 0;
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            if (n % i == 0)
                            {
                                a++;
                            }
                        }
                        if (a == 2)
                        {
                            Console.WriteLine("is a Prime Number", n);
                        }
                        else
                        {
                            Console.WriteLine("Not a Prime Number");
                        }
                 */
            /*Write a C# Sharp program to swap two numbers
                   //Option1
                    Console.WriteLine("Please Enter your First Number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please Enter your Second Number");
                    int num2 = int.Parse(Console.ReadLine());
                    int val3 = num2;
                    num2 = num1;
                    num1 = val3;
                    Console.WriteLine("After swapping values: \n Variable1 = {0} \n Variable2 = {1}", num1, num2);
            

                    int num1, num2, temp;
                    Console.WriteLine("Please Enter your First Number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Enter your second Number");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Before swapping num1 = {0} and num2 = {1}", num1,num2);
                            temp = num1;
                            num1 = num2;
                            num2 = temp;
                    Console.WriteLine("After swapping num1 = {0} and num2 = {1}", num1, num2);
                   //Console.WriteLine("Press any key to exit");
             */
            Console.ReadLine();
            
        }
    }
}
