using System;
using System.Linq;

namespace RockPaperScissor
{
    class Program
    {
        public static int wins = 0;
        public static int loss = 0;
        public static int tie = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("|       WELCOME TO ROCK, PAPER, SCISSOR!          |");
            Console.WriteLine("--------------------------------------------------");
            while (true)
            {
                string[] choices = { "r", "p", "s", "q" };
                Console.WriteLine($"Wins: {wins} | Losses: {loss} | Ties: {tie}");

                Console.Write("Enter (R, P, S) or Q to quit: ");
                string user = Console.ReadLine().ToLower();

                Random random = new Random();
                int randomIndex = random.Next(choices.Length);
                string computerChoice = choices[randomIndex].ToLower();
                
                
                if (user == "q")
                {
                    Environment.Exit(0);
                }
                
                else if (!choices.Contains(user))
                {
                    Console.WriteLine("Invalid input. Please try again.\n");
                }

                else if (user == "r" && computerChoice == "s" || user == "p" && computerChoice == "r" || user == "s" && computerChoice == "p")
                {
                    wins++;
                    Console.WriteLine("You win! \n");
                    
                    
                }
                else if (user == "r" && computerChoice == "r" || user == "p" && computerChoice == "p" || user == "s" && computerChoice == "s")
                {
                    tie++;
                    Console.WriteLine("I'ts a tie! \n");
                }
                else
                {
                    loss++;
                    Console.WriteLine("Computer wins! \n");
                }

            }
        }
    }
}

