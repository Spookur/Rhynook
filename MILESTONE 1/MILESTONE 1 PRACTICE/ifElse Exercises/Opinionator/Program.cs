using System;

namespace Opinionator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            Console.WriteLine("I can't decide what animal I like the best...");
            Console.WriteLine("Eureka! Random can decide for me!");

            int x = randomizer.Next(5);

            Console.WriteLine("The number we chose was: " + x);

            if (x == 0)
            {
                Console.WriteLine("Llamas are the best.");
            }
            else if (x == 1)
            {
                Console.WriteLine("Dodos are the best!");
            }
            else if (x == 2)
            {
                Console.WriteLine("Mammoths are the SHIT!");
            }
            else if (x == 3)
            {
                Console.WriteLine("Sharks are the greatest, they have their own week...");
            }
            else if (x == 4)
            {
                Console.WriteLine("Cockatoos are just too awesome.");
            }
            else if (x == 5)
            {
                Console.WriteLine("Ever meet a Beavcoon?");
            }

            Console.WriteLine("Thanks random. Maybe YOU'RE the best...");
        }
    }
}
