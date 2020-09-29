using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLaddersGame
{
    class Program
    {
        public const int START_POINT = 0;
        public const int END_POINT = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snakes and ladders game \nEnter player name");
            string player1 = Console.ReadLine();
            int playerPosition = START_POINT;
            Console.WriteLine("Current Position : " + playerPosition);
        }
    }
}
