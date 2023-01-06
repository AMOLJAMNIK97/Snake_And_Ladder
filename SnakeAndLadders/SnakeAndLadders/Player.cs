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
        public static  void CheckOption()
        {
            const int No_Play = 1;
            const int Ladder = 2;
            const int Snake = 3;
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
                case Snake:
                    position = position - dice;
                    break;
                default:
                    position = 0;
                    break;
            }
            Console.WriteLine("postion of player is :" + position);
        }
        public static void CheckPostionTill100()
        {
            const int NO_PLAY = 1;
            const int LADDER = 2;
            const int SNAKE_BITE = 3;
            int position = 0;

            while (position <= 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int checkOption = random.Next(1, 4);
                switch (checkOption)
                {
                    case NO_PLAY:
                        position = 0;
                        break;
                    case LADDER:
                        position = position + dice;
                        break;
                    case SNAKE_BITE:
                        position = position - dice;
                        break;
                    default:
                        position = 0;
                        break;
                }
                if (position < 0)
                {
                    Console.WriteLine("Player restarts from 0");
                }
                else
                {
                    Console.WriteLine("Player stays in same postion");
                }
            }
        }
        public static void ExactWinTill100()
        {
            const int NO_PLAY = 1;
            const int MOVES_AHEAD = 2;
            const int MOVES_BEHIND = 3;
            int position = 0;

            while (position <= 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int checkOption = random.Next(1, 4);
                int previousPosition = position;
                switch (checkOption)
                {
                    case NO_PLAY:
                        position = 0;
                        break;
                    case MOVES_AHEAD:
                        position = position + dice;
                        break;
                    case MOVES_BEHIND:
                        position = position - dice;
                        break;

                    default:
                        position = 0;
                        break;
                }
                if (position > 100)
                {
                    position = previousPosition;
                    Console.WriteLine("PLAYER STAYS IN SAME POSITION: " + position);
                }
                else
                {
                    position = 100;
                }
            }
        }
        public static void DiceRoll()
        {
            const int NO_PLAY = 1;
            const int MOVES_AHEAD = 2;
            const int MOVES_BEHIND = 3;
            int DICE_COUNT = 0;
            int position = 0;
            while (position < 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int checkOption = random.Next(1, 4);
                int previousPosition = position;
                switch (checkOption)
                {
                    case NO_PLAY:
                        position = 0;
                        break;
                    case MOVES_AHEAD:
                        position = position + dice;
                        break;
                    case MOVES_BEHIND:
                        position = position - dice;
                        break;

                    default:
                        position = 0;
                        break;
                }
                if (position > 100)
                {
                    position = previousPosition;
                    Console.WriteLine("Dice poition after role " + dice);

                }

            }
            Console.WriteLine("Number of dice was played :" + DICE_COUNT);
        }
    }
}
