using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
