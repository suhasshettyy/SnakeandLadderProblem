using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeandLadderProblem
{
    class snakeandladder
    {
        public void Dice()
        {
            Random random = new Random();
            int roll = random.Next(1, 7);
            Console.WriteLine(roll);
        }
    }
}