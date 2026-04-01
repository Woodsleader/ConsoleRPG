using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    internal class Game
    {
        public static void GameRunning()
        {
            bool isRunning = true;
            while (isRunning)
            {

            }
        }

        public static void MainMenu()
        {
            Console.WriteLine("1 - Character \n 2 - Shop \n 3 - Tavern \n 4 - Dungeon");
        }

        public static string AskHeroName()
        {
            Console.WriteLine("State your name, adventurer.");
            string inputRaw = Console.ReadLine();
            while (string.IsNullOrEmpty(inputRaw) || inputRaw.Any(x => char.IsDigit(x)))
            {
                Console.WriteLine("Invalid name, try again");
                Console.WriteLine("State your name, adventurer.");
                inputRaw = Console.ReadLine();
            }
            string inputTrimmed = inputRaw.Trim();
            string inputClean = char.ToUpper(inputTrimmed[0]) + inputTrimmed.Substring(1).ToLowerInvariant();
            return inputClean;
        }
    }
}
