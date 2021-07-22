using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeandLadderProblem
{
    class Snakeandladder
    {

        public int position = 0;
        public int diceCount = 0;
        public void Dice()
        {
            while (position < 100)
            {
                diceCount += 1;
                Console.WriteLine("The current position of the player is = " + position);
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("Then the player got in dice : " + dice);
                int choice = random.Next(1, 3);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The player got ladder");
                        position += dice;
                        if (position > 100)
                            position -= dice;
                        Console.WriteLine("The position of player after dice = " + position);
                        break;
                    case 2:
                        Console.WriteLine("The player got snake");
                        position -= dice;
                        if (position < 0)
                            position = 0;
                        Console.WriteLine("The position of player after dice = " + position);
                        break;
                    default:
                        Console.WriteLine("The player got nothing ");
                        Console.WriteLine("The position of player after dice = " + position);
                        break;
                }
            }
            Console.WriteLine("Dice count is : " + diceCount);
        }
    }
}