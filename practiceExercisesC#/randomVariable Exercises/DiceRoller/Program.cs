using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Random diceRoller = new Random();

            int rollResult = diceRoller.Next(6) + 1;

            Console.WriteLine("TIME TO ROOOOOOLL THE DICE!");
            Console.WriteLine("I rolled a " + rollResult + ".");

            if (rollResult == 1)
            {
                Console.WriteLine("You rolled a critical failure!");
            }
            else if (rollResult == 2)
            {
                Console.WriteLine("Snake-eyes!");
            }

        }
    }
}