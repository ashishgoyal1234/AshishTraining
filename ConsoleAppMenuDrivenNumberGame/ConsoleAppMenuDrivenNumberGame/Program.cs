using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppMenuDrivenNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("----------");
                Console.WriteLine("1: Start new game");
                Console.WriteLine("2: Show best score");
                Console.WriteLine("3: Reset best score");
                Console.WriteLine("4: Exit");
                Console.WriteLine("Chose an option and enter the option number");

                string input = Console.ReadLine();
                //string input = Console.ReadLine() ?? "";
                string[] options = { "1", "2", "3", "4" };
                bool valid = false;

                for (int i = 0; i < options.Length; i++)
                {
                    if (input == options[i])
                    {
                        valid = true;
                        if (i == 0)
                            game.Start();

                        else if (i == 1)
                            game.ShowBestScore();

                        else if (i == 2)
                            game.ResetBestScore();
                        else if (i == 3)
                        {
                            Console.WriteLine("Good bye");
                            return;
                        }
                    }
                    Console.WriteLine("Invalid selection, please choose 1-4");
                }
            }
        }
    }
}
