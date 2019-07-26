using System;

namespace GuessMeV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            int myDude = 15;

            Console.WriteLine("Pick a number! (HINT: It's my favorite number.)");

            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > myDude)
            {
                Console.WriteLine("Nice try. But it's too high. Guess again please.");
            }
            if (guess < myDude)
            {
                Console.WriteLine("Good guess, but not quite right. Shoot HIGHER!");
            }
            if (guess == myDude)
            {
                Console.WriteLine("Congratulations! You've won: Nothing! MUHAHHAAHAHAHHAHAHAHAHAHAAHHAHAHA");
                Console.WriteLine("SYSTEM MALFUNCTION");
            }


        }
    }
}
