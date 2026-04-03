using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleRPG
{
    internal class Game
    {
        public static void GameRunning()
        {
            var Player = new Hero();
            AskHeroName();
            bool isRunning = true;
            while (isRunning)
            {
                MainMenu();
            }
        }

        private static void MainMenu()
        {
            Console.WriteLine("1 - Character \n2 - Shop \n3 - Tavern \n4 - Dungeon");
            switch (UserChoice(1, 4))
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        private static void CharacterMenu()
        {
            Console.WriteLine("1 - Equip items \n2 - Unequip items \n 3 - View equipped items \n 4 - Character stats \n 5 - Leave");
            switch (UserChoice(1, 5))
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }

        //Name and choices check.
        public static int UserChoice(int min, int max)
        {
            while (true)
            {
                Console.WriteLine($"Select a number between {min} and {max},");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice) && choice >= min && choice <= max)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Incorrect number, try again");
                }
            }
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
