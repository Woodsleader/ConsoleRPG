using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ConsoleRPG
{
    internal class Game
    {

        public void GameRunning()
        {
            bool isRunning = true;
            while (isRunning)
            {

            }
        }

        public string AskHeroName()
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
