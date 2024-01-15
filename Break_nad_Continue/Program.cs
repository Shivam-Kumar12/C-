using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_nad_Continue
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Break");
            for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        Console.WriteLine("Breaking out of the loop at iteration 5");
        break;
    }
    Console.WriteLine($"Iteration {i}");
}

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Skipping iteration 3 using continue");
                    continue;
                }
                Console.WriteLine($"Iteration {i}");
            }

            Console.ReadLine();

        }
    }
}
