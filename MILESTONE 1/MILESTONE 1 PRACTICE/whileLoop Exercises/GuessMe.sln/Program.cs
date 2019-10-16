using System;

namespace GuessMe.sln
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int randomNumber = random.Next(1, 11);
            int guess;
            int numberOfGuesses = 3;
            bool gameOver = false;

            Console.WriteLine("I am thinking of a number between 1-10. Can you guess it? :)");

            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;

                if (guess != randomNumber && numberOfGuesses == 0)
                {
                    Console.WriteLine("Wow, three guesses and you can't figure it out?! YOU LOSE!!");
                    gameOver = true;
                }
                else if (guess == randomNumber)
                {
                    Console.WriteLine("That's it! YOU WIN!! How did you read my mind?");
                    gameOver = true;
                }
                else if (guess > randomNumber)
                    Console.WriteLine("Nope! My number is smaller than that, you dingus.");
                else if (guess < randomNumber)
                    Console.WriteLine("Nope! My number is greater than that, silly goose.");
            }

            Console.ReadLine();
        }
    }
}
