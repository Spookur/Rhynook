using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessingGame.BLL;


namespace GuessingGame.UI
{
    public class ConsoleOutput
    {
        public static void DisplayTitle()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Better, Testable, Guessing Game!\n\n");
            Console.WriteLine("Press any key to start the game.");
            Console.ReadKey();
        }

        public static void DisplayGuessMessage(GuessResult result)
        {
            switch (result)
            {
                case GuessResult.Invalid:
                    DisplayInvalid();
                    break;
                case GuessResult.Higher:
                    DisplayHigher();
                    break;
                case GuessResult.Lower:
                    DisplayLower();
                    break;
                case GuessResult.Victory:
                    DisplayVictory();
                    break;
            }
        }

        private static void DisplayVictory()
        {
            Console.WriteLine("You did it! You are winner!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
        private static void DisplayLower()
        {
            Console.WriteLine("Your guess was a bit too high. Try aiming lower.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayHigher()
        {
            Console.WriteLine("Your guess was too low. Try shooting higher.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayInvalid()
        {
            Console.WriteLine("That guess wasn't valid. Try something between 1 and 20.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}
