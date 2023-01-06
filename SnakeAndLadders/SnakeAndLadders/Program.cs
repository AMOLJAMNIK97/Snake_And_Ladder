using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snak And Ladder Game ");
            Console.WriteLine("Choose option\n 1. Single player position\n2.Roll The Dice\n3.Player Check Option\n4. Check Position Till 100\n5. Exact Wining Postion");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Player.Position();
                    break;
                case 2:
                    Player.RollDice();
                    break;
                case 3:
                    Player.CheckOption();
                    break;
                case 4:
                    Player.CheckPostionTill100();
                    break;
                case 5:
                    Player.ExactWinTill100();
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}