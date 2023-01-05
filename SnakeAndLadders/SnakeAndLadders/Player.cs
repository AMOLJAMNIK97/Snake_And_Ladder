using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class Player
    {
        public static void Position()
        { 

             int Position = 0;
             Console.WriteLine("Player is at starting  Position: " + Position);
        }
        public static void RollDice()
        {
            int player1 = 0;
            Random random = new Random();
            player1 = random.Next(1, 6);
            Console.WriteLine("get the number: " + player1);
        }
    }
}
