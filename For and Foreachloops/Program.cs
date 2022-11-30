using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_and_Foreachloops
{
    internal class Program
    {
        static void Main(string[] args)
        /*For Loop
        For loop is very similar to while loop. In a while loop we do the the initialization at one place,
        condition check at another places and modifying the variable an another place 
        where as for loop has all of these at one place.
        
         For each loop is used to iterate through the item in a collection 
         example foreach loop can be used with arrays or collection such as ArrayList,HashTable and generics
         */
        {
            /*
            int[] numbers = new int[5];
                    numbers[0] = 1;
                    numbers[1] = 2;
                    numbers[2] = 3;
                    numbers[3] = 4;
                    numbers[4] = 5;
            string [] Employee = new string[5];
                    Employee[0] = "Redwan";
                    Employee[1] = "Yoseph";
                    Employee[2] = "Thomas";
                    Employee[3] = "Philip";
                    Employee[4] = "Saqib";
            */
            //for Each loop
            /* 
        foreach (int i in numbers)
                {
                    Console.WriteLine("The Result is {0}" ,i);
                }
                 Console.ReadLine();*/

            /*
            foreach (string E in Employee)
                    {
                        Console.WriteLine("Employe Name is {0}",E) ;
                       // Console.ReadLine(); 
                    }
            */

            // for loop
            /*
            for (int j = 0; j < numbers.Length; j++)
                    {
                        Console.WriteLine(numbers[j]);
                    }
            */
            // erro
            /*
            for (int j = 0; j <= numbers.Length; j++)
                {
                    Console.WriteLine(numbers[j]);
                }
            */
            //while loop
            /*
                    int i = 0;
                    while (i < numbers.Length)
                    {
                        Console.WriteLine(numbers[i]);
                        i++;
                    }
            */

            //BREAK
            /*
        for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i == 10)
                break;

            }
            */
            /*continue/ print Even Number

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);

              
            }
           */
            /**/
            Console.WriteLine("Please Provide Number of Row");
            int N = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();

                Console.ReadLine();
            }
            
        }     
    }
}
