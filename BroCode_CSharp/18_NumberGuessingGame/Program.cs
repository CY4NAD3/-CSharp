using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace _18_NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int noOfAttempts;
            string response;

            while (playAgain) 
            {
                guess = 0;
                noOfAttempts = 0;
                number = random.Next(min, max + 1);
                response = string.Empty; //or ""

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between {0} and {1}:", min, max);
                    guess = int.Parse(Console.ReadLine());
                    Console. WriteLine("Your guess:" + guess);

                    if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low! Try again.");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high! Try again.");
                    }
                    noOfAttempts++;
                }
                Console.WriteLine("Congratulations! You've guessed the number {0} in {1} attempts.", number, noOfAttempts);
                Console.WriteLine("Do you want to play again? (y/n)");
                response = Console.ReadLine();
                response = response.ToLower();

                if (response == "y")  //playAgain = reponse == "y"; can also be used
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            
            Console.ReadKey();
        }
    }
}
