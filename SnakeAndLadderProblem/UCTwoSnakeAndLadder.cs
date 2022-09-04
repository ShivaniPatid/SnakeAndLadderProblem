using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class UCTwoSnakeAndLadder
    {
        public static void RollsThedie()
        {
            Random random = new Random();
            int num = random.Next(1, 7);
            Console.WriteLine("The player get a number is " + num);
        }
    }
}
