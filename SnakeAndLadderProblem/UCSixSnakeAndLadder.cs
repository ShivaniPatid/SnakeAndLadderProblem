using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class UCSixSnakeAndLadder
    {
        public static void ReportNumber()
        {
            int option = 0, dice = 0, diceCount=0;
            const int IS_LADDER = 1;
            const int IS_SNAKE = 2;
            int positionOfPlayer = 0;
            while (positionOfPlayer < 100)
            {
                diceCount++;
                Random random = new Random();
                option = random.Next(0, 3);
                dice = random.Next(1, 7);

                switch (option)
                {
                    
                    case IS_LADDER:
                        positionOfPlayer = positionOfPlayer + dice;
                        break;
                    case IS_SNAKE:
                        positionOfPlayer = positionOfPlayer - dice;
                        if (positionOfPlayer < 0)
                        {
                            positionOfPlayer = 0;
                        }
                        break;

                    default:
                        //Console.WriteLine("The player stays in same position");
                        break;
                }
                if (positionOfPlayer > 100)
                {

                    Console.WriteLine("Can't move, Please roll again..... Position is greater than 100 : " + positionOfPlayer);
                    positionOfPlayer = positionOfPlayer - dice;
                }
                Console.WriteLine("Position of player is " + positionOfPlayer + " and rolled a die : " + dice);
            }
            
            Console.WriteLine("The total number of time die was rolled to win the game : "+diceCount);
        }
    }
}
