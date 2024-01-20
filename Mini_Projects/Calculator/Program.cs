using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string answer;
            int result;
            Console.WriteLine("Hello,Welcome To The calculator Program");
            Console.WriteLine("Please Enter You first Number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter You Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What Type of operation would You like To Do");
            Console.WriteLine("please Enter A for Addition S for subtraction M for Multiply D for Divide");
            answer=Console.ReadLine();

            if(answer == "A") 
            {
                result = num1 + num2;
                Console.WriteLine($"The Result is {num1} and {num2} is:"+result);
            }
            else if(answer=="S")
            {
                result = num1 - num2;
                Console.WriteLine($"The Result is {num1} and {num2} is:" + result);
            }
            else if (answer == "M")
            {
                result = num1 * num2;
                Console.WriteLine($"The Result is {num1} and {num2} is:" + result);
            }
            else if (answer == "D")
            {
                result = num1 / num2;
                Console.WriteLine($"The Result is:" + result);
            }
            Console.WriteLine("Thanku for Using the calculator");

            Console.ReadKey();


        }
    }
}
