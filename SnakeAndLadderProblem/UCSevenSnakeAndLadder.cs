using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
   
    internal class UCSevenSnakeAndLadder
    {
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        public const int IS_PLAYER1 = 1;
        public const int IS_PLAYER2 = 2;
        public static void PlayWithTwoPlayer()
        {
            int player = 1;
            int PositionOfPlayer1 = 0;
            int PositionOfPlayer2 = 0;
            int dieRollCount = 0;

            while (PositionOfPlayer1 < 100 && PositionOfPlayer2 < 100)
            {
                dieRollCount++;
                Random random = new Random();
                int dice = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case IS_LADDER:
                        Console.WriteLine($"The player {player} rolled a die " + dice);
                        Console.WriteLine($"Yeah! Player{player}, its a ladder,you are moving ahead");
                        if (player == IS_PLAYER1)
                            PositionOfPlayer1 += dice;
                        else
                            PositionOfPlayer2 += dice;
                        break;

                    case IS_SNAKE:
                        Console.WriteLine($"The player {player} rolled a die " + dice);
                        Console.WriteLine($"Opss! Player{player}, its a snake,you are going down");

                        if (player == IS_PLAYER2)
                        {
                            PositionOfPlayer2 -= dice;
                            if (PositionOfPlayer2 < 0)
                                PositionOfPlayer2 = 0;
                        }
                        else
                        {
                            PositionOfPlayer1 -= dice;
                            if (PositionOfPlayer1 < 0)
                                PositionOfPlayer1 = 0;
                        }
                        break;

                    default:
                        Console.WriteLine($"Player {player},You cannot move");
                        break;
                }
                if (PositionOfPlayer1 > 100 || PositionOfPlayer2 > 100)
                {

                    Console.WriteLine($"Player {player}Cannot move ...rolling again");
                    if (player == IS_PLAYER1)
                        PositionOfPlayer1 -= dice;
                    else
                        PositionOfPlayer2 -= dice;


                }
                Console.WriteLine("position of player 1 : \t" + PositionOfPlayer1);
                Console.WriteLine("position of player 2 : \t" + PositionOfPlayer2);

                if (option == IS_LADDER)
                {
                    Console.WriteLine($"Congrats! its an ladder, Player{player}, got one more Chance to roll the die");
                }
                else if (player == IS_PLAYER1)
                {
                    Console.WriteLine("Second Player turn");
                    player = 2;
                }
                else
                {
                    Console.WriteLine("First Player Turn");
                    player = 1;
                }
            }
            Console.WriteLine("The total no of time die was rolled to win is :" + dieRollCount);
            if (PositionOfPlayer1 == 100)
            {
                Console.WriteLine("Player1 Wins");
            }
            else
            {
                Console.WriteLine("Player2 Wins");
            }

        }

    }
}
