using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        /* Data types in C#
          Integer- int harry --->4bytes
         Floating point number-float that--->4bytes
         character- char a='A';--->2bytes
        Double - double harry;--->8bytes
        Boolean- bool isGreat=true;--->1 bit
        String= String inp="Harry--->2bytes/char

         */
        static void Main(string[] args)
        {
            /*String inp = Console.ReadLine();
            Console.WriteLine(inp);
             Console.ReadLine();
             */

            /* int harry = 34;
             Console.WriteLine("hello world");
             Console.Write("I am Shivam");
             Console.WriteLine(" What are You doing" +harry );*/

            /*Datatypes Example*/
            /*           int a = 34;
                       double b = 34.4D;
                       bool isGreat = true;
                       char d = 'r';
                       Console.WriteLine(a);
                       Console.WriteLine(b);
                       Console.WriteLine(d);
                       Console.WriteLine(isGreat);*/

            /*Type Casting*/
            /*    There are two ttypes of typecasting
                1.Explicit Typcasting
            //char to int to long to float to double
                2.Implicit Typcasting*/

            //    int x = (int)3.5;
            /*    int x = 3;
                double y = 4;
                int z = 'y';
                float varr = Convert.ToInt32(3.55);
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);    
                Console.ReadLine();*/
            /*  Console.WriteLine("Enter your Name");
              string name=Console.ReadLine();
              Console.WriteLine("hey Hello" + name);

              Console.WriteLine("How many candies do you want");
              string can=Console.ReadLine();
              Console.WriteLine("You will get 4 more candies :" + (Convert.ToInt32(can) + 4));
              Console.ReadLine();*/

           

           

            //String
            /*    String hello = "Hello world,here I am Shivam";
                Console.WriteLine(hello.Length);
                Console.WriteLine(hello.ToUpper());
                Console.WriteLine(hello.ToLower());
                Console.WriteLine(hello + "i am a good boy");
                Console.WriteLine(String.Concat(hello, "how arae you"));

                string Name = Console.ReadLine();
                String candies= Console.ReadLine();
                Console.WriteLine($"Your Name Is {Name} You will get  {candies} candies");*/

            /*  String hello = "Hello world,here I am Shivam";
              Console.WriteLine(hello[1]);
              Console.WriteLine(hello.IndexOf('I'));
              Console.WriteLine(hello.Substring(3));
            */


            //If-ELSe

            /*Console.WriteLine("Enter Your Age");
            string ageStr = Console.ReadLine();

            int age = Convert.ToInt32(ageStr);
            if (age > 18)
            {
                Console.WriteLine("You are Eligible to Vote");
            }
            else { 
                Console.WriteLine("You are Not Eligible");
            }*/


            //Switch
            Console.WriteLine("Enter a day of the week:");

            string day = Console.ReadLine();

            switch (day.ToLower()) // Convert the input to lowercase for case-insensitive comparison
            {
                case "monday":
                    Console.WriteLine("It's the start of the week!");
                    break;

                case "tuesday":
                case "wednesday":
                case "thursday":
                    Console.WriteLine("It's a weekday.");
                    break;

                case "friday":
                    Console.WriteLine("TGIF! It's Friday!");
                    break;

                case "saturday":
                case "sunday":
                    Console.WriteLine("It's the weekend!");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a valid day of the week.");
                    break;
            }
            Console.ReadLine();

            }
        }
    }
