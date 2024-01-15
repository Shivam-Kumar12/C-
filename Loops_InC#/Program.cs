using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_InC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"For loop iteration {i}");
            }
            Console.WriteLine("While Loop");
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine($"While loop iteration {j}");
                j++;
            }
            Console.WriteLine("Do-While Loop");
            int k = 1;
            do
            {
                Console.WriteLine($"Do-while loop iteration {k}");
                k++;
            } while (k <= 5);



            Console.ReadLine();




        }
    }
}
