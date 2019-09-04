using System;

namespace KnockKnock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Knock knock! Guess who?");
            string nameGuess = Console.ReadLine();

            if (nameGuess.Equals("Coberto")) 
            {
                Console.WriteLine("What's going on guys it's your boy Coberto BE SURE TO FUCKING SLAP THE SHIT OUT OF LIKE AND LEAVE A DANG COMMENT.");
            }
            else
            {
                Console.WriteLine("Dude, wrong guess. What are you thinking?");
            }
        }
    }
}
