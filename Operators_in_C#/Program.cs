using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Operators in C#
            *  1.Arithemetic Operator
            *  2.Assignment Operator
            *  3.Logical operator
            *  4.Comparison Operator

            */
            //Arithmetic operator
               int a = 4;
               int b = 2;
               Console.WriteLine("The value of a+b is:"+(a + b));
               Console.WriteLine("The value of a-b is:" + (a - b));
               Console.WriteLine("The value of a*b is:" + (a * b));
               Console.WriteLine("The value of a/b is:" + (a / b));
               Console.WriteLine("The value of a%b is:" + (a % b));

            //Assignment operator
            Console.WriteLine("Assignment Operator");

            int x = 4;
                      int y = x;
                      y += 4;
            Console.WriteLine("The value of y is:"+y);
            /* y -= 4;
              //y *= 4;
              //b /= 4;
              */

            //Logical Operator
            Console.WriteLine("Logical Operator");

            Console.WriteLine(true || false);
             Console.WriteLine(true|| true);
             Console.WriteLine(false||false);
             Console.WriteLine(!false);
             Console.WriteLine(!true);

            //Comparison Operator
            Console.WriteLine("Comparison Operator");
            Console.WriteLine(324>555);
             Console.WriteLine(324 <= 555);
             Console.WriteLine(5 == 5);

            //Math Function
            Console.WriteLine("Math function");
            int p = Math.Min(34, 345);
                int q = Math.Max(34, 345);
                Double r= Math.Sqrt(36);
                //Absolute value
                int d = Math.Abs(-39);            
                Console.WriteLine(p);
                Console.WriteLine(q);
                Console.WriteLine(r);
                Console.WriteLine(d);


            Console.ReadLine();
        }
    }
}
