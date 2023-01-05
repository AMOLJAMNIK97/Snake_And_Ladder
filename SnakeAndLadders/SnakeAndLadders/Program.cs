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
            Console.WriteLine("Welcome to SNAKE & LADDER!");
            Console.WriteLine("Choose option\n 1. Single player position");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Player.Position();
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}