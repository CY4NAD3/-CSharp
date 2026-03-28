using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = 0;
            bool playAgain = true;
            String userChoice;
            String computerChoice;
            String response;

            while (playAgain)
            {
                userChoice = "";
                computerChoice = "";

                while (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
                {
                    Console.WriteLine("Enter your choice (rock, paper, scissors):");
                    userChoice = Console.ReadLine();
                    userChoice = userChoice.ToLower();
                }

                switch(random.Next(1, 4))
                {
                    case 1:
                        computerChoice = "rock";
                        break;
                    case 2:
                        computerChoice = "paper";
                        break;
                    case 3:
                        computerChoice = "scissors";
                        break;
                    default:
                        computerChoice = "rock";
                        break;
                }

                Console.WriteLine("Player's choice: " + userChoice);
                Console.WriteLine("Computer's choice: " + computerChoice);

                switch (userChoice)
                {
                    case "rock":
                        if (computerChoice == "rock")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if(computerChoice == "paper")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!!");
                        }
                        break;

                    case "paper":
                        if (computerChoice == "rock")
                        {
                            Console.WriteLine("You Win!!");
                        }
                        else if(computerChoice == "paper")
                        {
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            Console.WriteLine("You Lose!");
                        }
                        break;

                    case "scissors":
                        if (computerChoice == "rock")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else if (computerChoice == "paper")
                        {
                            Console.WriteLine("You Win!!");
                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }
                        break;
                }
                Console.WriteLine("Would you like to play again? (y/n): ");
                response = Console.ReadLine();
                response = response.ToLower();

                switch (response)
                {
                    case "y":
                        playAgain = true;
                        break;
                    case "n":
                        playAgain = false;
                        break;
                    default:
                        playAgain = false;
                        break;
                }
            }
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}
