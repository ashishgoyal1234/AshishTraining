using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMenuDrivenNumberGame
{
    internal class Game
    {
        private int bestscore = 0;
        private readonly Random random = new Random();

        public void Start()
        {
            int target = random.Next(1, 101);
            int guessCount = 0;
            Console.WriteLine(target);
            while (true)
            {
                int guess = PromptForGuess();
                guessCount++;

                if (guess < target)
                {
                    Console.WriteLine("Low");
                }
                else if (guess > target)
                {
                    Console.WriteLine("High");
                }
                else
                {
                    Console.WriteLine($"Win - You guessed in {guessCount} tries");
                    UpdateBestScore(guessCount);
                    break;
                }
                //return;
            }
        }

        private int PromptForGuess()
        {
            while (true)
            {
                Console.WriteLine("Input your guess from 1 to 100: ");
                int input = int.Parse(Console.ReadLine() ?? "");
                if ((input) >= 1 && (input) <= 100)
                {
                    return (input);
                }
                //if (int.TryParse(input, out int guess) && guess >= 1 && guess <= 100)
                //{ return guess; }
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 100.");
            }
        }

        private void UpdateBestScore(int currentScore)
        {
            //int bestscore = _bestscore;
            if (bestscore == 0 || currentScore < bestscore)
            {
                bestscore = currentScore;
                Console.WriteLine("You got a new best score");
            }
        }

        public void ShowBestScore()
        {
            if (bestscore == 0)
                Console.WriteLine("No best score yet.");
            else
                Console.WriteLine($"Best score is {bestscore} attempts");
        }

        public void ResetBestScore()
        {
            bestscore = 0;
            Console.WriteLine("Best score has been reset.");
        }
    }
}
