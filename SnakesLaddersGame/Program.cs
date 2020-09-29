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
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snakes and ladders game \nEnter players name");
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();
            Console.WriteLine(player1 + " playing");
            int score1 = Score();
            Console.WriteLine(player1 + " score: " + score1);
            Console.ReadLine();
            Console.WriteLine(player2 + " playing");
            int score2 = Score();
            Console.WriteLine(player2 + " score: " + score2);
            Console.ReadLine();
            if (score1 > score2)
            {
                Console.WriteLine(player2 + " Won!");
            }
            else if (score2 > score1)
            {
                Console.WriteLine(player1 + " Won");
            }
            else
            {
                Console.WriteLine("Its a tie");
            }
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
        static int PlayerMovement(int numberRolled, int playerPosition)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
            switch (move)
            {
                case NO_PLAY:
                    Console.WriteLine("No Play");
                    break;
                case SNAKE:
                    Console.WriteLine("Snake");
                    if (playerPosition - numberRolled >= 0)
                    {
                        playerPosition = playerPosition - numberRolled;
                        break;
                    }
                    else
                    {
                        playerPosition = START_POINT;
                        break;
                    }
                case LADDER:
                    Console.WriteLine("Ladder");
                    if (playerPosition + numberRolled <= 100)
                    {
                        playerPosition = playerPosition + numberRolled;
                        break;
                    }
                    else
                        break;
            }
            return playerPosition;
        }
        static int Score()
        {
            int position = 0;
            int noOfTimesDiceRolled = 0;
            while (position != 100)
            {
                int playerCurrentPosition = START_POINT;
                for (noOfTimesDiceRolled = 1; playerCurrentPosition < 100; noOfTimesDiceRolled++)
                {
                    int diceRoll = DiceRoll();
                    Console.WriteLine("You rolled: " + diceRoll);
                    int playerPreviousPosition = playerCurrentPosition;
                    playerCurrentPosition = PlayerMovement(diceRoll, playerCurrentPosition);
                    Console.WriteLine("Your position: " + playerCurrentPosition);
                    if (playerPreviousPosition < playerCurrentPosition)
                    {
                        if (playerCurrentPosition != 100)
                        {
                            noOfTimesDiceRolled--;
                            Console.WriteLine("Roll Again");
                            continue;
                        }
                        else
                            continue;
                    }
                    if (playerCurrentPosition == 100)
                    {
                        Console.WriteLine("No. of times die rolled: " + noOfTimesDiceRolled);
                        Console.WriteLine("Game Over");
                        break;
                    }
                    Console.WriteLine("No. of times die rolled: " + noOfTimesDiceRolled);
                    Console.WriteLine("\nNext Roll");
                    Console.ReadLine();
                }
                position = playerCurrentPosition;
            }
            return noOfTimesDiceRolled-1; 
        }
    }
}
