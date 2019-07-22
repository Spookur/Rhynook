using System;

namespace BewareTheKraken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alrighty! Get those flippers and wetsuit on - we're going diving!");
            Console.WriteLine("Here we goooOOooOooo.....! *SPLASH*");

            int depthDivedInFt = 0;

            // Turns out the ocean is only so deep, 36200 at the deepest survey,
            // so if we reach the bottom ... we should probably stop.
            while (depthDivedInFt < 36200)
            {
                Console.WriteLine("So far, we've swam " + depthDivedInFt + " feet");

                if (depthDivedInFt >= 20000)
                {
                    Console.WriteLine("Uhhh, I think I see a Kraken, guys ....");
                    Console.WriteLine("TIME TO GO!");
                    break;
                }

                // I can swim, really fast! 500ft at a time!
                depthDivedInFt += 1000;
            }
            Console.WriteLine("");
            Console.WriteLine("We ended up swimming " + depthDivedInFt + " feet down.");
            Console.WriteLine("I bet we can do better next time!");
        }
    }
}
