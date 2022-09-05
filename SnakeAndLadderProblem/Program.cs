namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose Option\n 1. Played with single player\n 2. The Player rolls the die to get a number\n 3. check no play, ladder or snake\n 4. winning when reached 100\n 5. Exact winning position 100\n 6. number of times the dice was played to win the game\n 7. Played with two players");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {

                case 1:
                    UCOneSnakeAndLadder.PlayerPsition();
                    break;
                case 2:
                    UCTwoSnakeAndLadder.RollsThedie();
                    break;
                case 3:
                    UCThreeSnakeAndLadder.CheckForOption();
                    break;
                case 4:
                    UCFourSnakeAndLadder.WinningPosition();
                    break;
                case 5:
                    UCFiveSnakeAndLadder.ExactWinningPosition();
                    break;
                case 6:
                    UCSixSnakeAndLadder.ReportNumber();
                    break;
                case 7:
                    UCSevenSnakeAndLadder.PlayWithTwoPlayer();
                    break;
                default:
                    Console.WriteLine("Choose a right option");
                    break;
            }
        }
    }
}