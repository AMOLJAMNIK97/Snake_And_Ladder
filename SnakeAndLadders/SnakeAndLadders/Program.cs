using System;
using System.Collections.Generic;
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
            Console.WriteLine("Choose option\n 1. Single player position\n2.Roll The Dice\n3.Player Check Option");
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
                 
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}