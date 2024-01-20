using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Dice_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerrandom;
            int enemyrandom;
            int playerpoints=0;
            int enemypoints=0;
            Random rand = new Random();

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Press any Key to roll the dice");
                Console.ReadKey();
                Console.WriteLine("Enter The no by user: ");
                playerrandom = rand.Next(1, 7);
                Console.WriteLine("you rolled a: " + playerrandom);

                Console.WriteLine(".....");
                System.Threading.Thread.Sleep(1000);


                enemyrandom = rand.Next(1, 7);
                Console.WriteLine("Enemy AI Rolled a :" + enemyrandom);

                if (playerrandom > enemyrandom)
                {
                    playerpoints++;
                    Console.WriteLine("Player Win The round");
                }
                else if (playerrandom < enemyrandom) {
                    enemypoints++;
                    Console.WriteLine("Enemy wins this round");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("The score is now - player: "+ playerpoints + " and - Enemy:"+enemypoints);
            }
       
            Console.ReadKey();
        }
    }
}
