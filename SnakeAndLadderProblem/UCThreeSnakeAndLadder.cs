using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class UCThreeSnakeAndLadder
    {
        public static void CheckForOption()
        {
            const int NO_PLAY = 0;
            const int IS_LADDER = 1;
            const int IS_SNAKE = 2;
            int positionOfPlayer = 0;

            Random random = new Random();
            int option = random.Next(0, 3);
            int dice = random.Next(1, 7);

            switch (option)
            {

                case NO_PLAY:
                    Console.WriteLine("The player stays in same position");
                    break;
                case IS_LADDER:
                    positionOfPlayer = positionOfPlayer + dice;
                    Console.WriteLine("Position of player is " + positionOfPlayer + " and rolled a die " + dice);
                    break;
                case IS_SNAKE:
                    positionOfPlayer = positionOfPlayer - dice;
                    if (positionOfPlayer < 0)
                    {
                        positionOfPlayer = 0;
                    }
                    Console.WriteLine("Position of player is " + positionOfPlayer + " and rolled a die " + dice);
                    break;

            }

        }
    }
}
