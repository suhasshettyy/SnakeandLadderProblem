using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeandLadderProblem
{
    class Snakeandladder
    {
        public void Dice()
        {
            int playerposition = 0;
            Random random = new Random();
            int roll = random.Next(1, 7);

            int option = random.Next(1, 3);
            switch (option)
            {
                case 1:
                    Console.WriteLine("Dice roll value is: " + roll);
                    Console.WriteLine("Ladder");
                    playerposition += roll;
                    Console.WriteLine("The player moves ahead by the number of position is: " + playerposition);
                    break;
                case 2:
                    Console.WriteLine("Dice roll value is: " + roll);
                    Console.WriteLine("Snake");
                    playerposition -= roll;
                    Console.WriteLine("The player moves behind by the number of position is: " + playerposition);
                    break;
                default:
                    Console.WriteLine("No play");
                    break;
            }

        }
    }
}