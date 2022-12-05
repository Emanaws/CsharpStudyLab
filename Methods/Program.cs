using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            /*
            this Methods is called static methods
            If the declaration mothed includes a static modifier, that motheds is called static motheds.
            no static modifier is present, the method is called instance mothed.
            Methods are called as Fuctions
            Methods are useful becouse they allow you to define your logic once and use it at many places
            public void EvenNumbers() ===>Instance Motheds
            public Static void EvenNumbers()====> Static Motheds
            VOID mean no return nothing Expected
             */
            //Program p = new Program();
            //p.EvenNumbers();
            //Program.EvenNumber()
            //DisplayMessage();
                int answer =  Add(5,10);
                Console.WriteLine(answer);
                int secondanswer = Add(answer,10);
                Console.WriteLine(secondanswer);
                int thirdanswer = Add(secondanswer,15);
                Console.WriteLine(thirdanswer);
                string Name = GetFullName("Redwan","Omer");
                Console.WriteLine(Name);

                //Pass by value
                int student1Grade = 85;
                Console.WriteLine( "Student Grade before extra credit {0}",student1Grade);
                Givestudentcredit(student1Grade);
                Console.WriteLine("Student Grade AFTER extra credit {0}", student1Grade);

                //pass by Refernce
                int[] grades = new int[1];
                grades[0] = student1Grade;
                Console.WriteLine("Student array grade before extra credit {0}", grades[0]);
                GiveExtraCreditArray(grades);
                Console.WriteLine("Student array grade After extra credit {0}", grades[0]);

            //out Keyword
            int Added;
            int Multiply;
            int Divide;
            int substract;

            Calc(5, 10, out Added, out Multiply, out Divide, out substract);
            Console.WriteLine("Result: {0}",Added);
            Console.WriteLine("Result: {0}",Multiply);
            Console.WriteLine("Result: {0}",Divide);
            Console.WriteLine("Result: {0}",substract);
        }
            /* 
            This is called instance motheds
            If we make instance methods as following public staic void EvenNumbers()
            we use Program.EvenNumber() on the above motheds
            */
       /* public void EvenNumbers()
        {
            int start = 0;
            while(start <= 10)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
            Console.ReadLine();
        }
        public static void Add(int n1, int n2)
        {
            int answer = n1 + n2;
            Console.WriteLine(answer);
        }*/
        public static int Add(int n1, int n2)
        {
            int answer = n1 + n2;
            //Console.WriteLine(answer);
            return answer;
        }

        public static string GetFullName(string FName, string LName)
        {
            string FullName  = FName + " " + LName;
            //Console.WriteLine(answer);
            return FullName;
        }
        //pass by Reference vs pass by value
        public static void Givestudentcredit(int studentGrade)
        {
            studentGrade += 5;
            Console.WriteLine("Student Grade AFTER extra credit inside methode {0}", studentGrade);
        }
        public static void GiveExtraCreditArray(int[] grades)
        {
            grades[0] += 5;
            //Console.ReadLine();
        }
        public static void Calc(int a, int b, out int added, out int Multiply,out int Divid,out int substract)
        {
               added = a+b;
               Multiply = a*b;
               Divid = a/b;
               substract = a-b;
            //Console.ReadLine();
        }

    }
}
