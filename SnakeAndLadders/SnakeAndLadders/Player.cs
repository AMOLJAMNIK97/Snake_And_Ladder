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
            player1 = random.Next(0, 7);
            Console.WriteLine("get the number: " + player1);
        }
        public static void CheckOption()
        {
            const int No_Play = 1;
            const int Ladder = 2;
            const int Snake_Bite = 3;
            int position = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);
            int checkOption = random.Next(1, 4);
            switch (checkOption)
            {
                case No_Play:
                    position = 0;
                    break;
                case Ladder:
                    position = position + dice;
                    break;
                case Snake_Bite:
                    position = position - dice;
                    break;
                default:
                    position = 0;
                    break;
            }
            Console.WriteLine("postion of player is :" + position);
        }
    }
}
