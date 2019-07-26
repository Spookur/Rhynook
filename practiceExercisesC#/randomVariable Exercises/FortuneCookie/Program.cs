using System;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            Console.WriteLine("So what's the fortune gonna be?");
            Console.WriteLine("Here it is...");

            int x = randomizer.Next(10);

            Console.WriteLine("The number we chose was: " + x);

            if (x == 0)
            {
                Console.WriteLine("");
            }
            else if (x == 1)
            {
                Console.WriteLine("Those aren't the droids we're looking for.");
            }

            else if (x == 2)
            {
                Console.WriteLine("Never go against a cecilian when death is on the line");
            }
            else if (x == 3)
            {
                Console.WriteLine("Goonies never say die.");
            }
            else if (x == 4)
            {
                Console.WriteLine("With great power comes great responsibility.");
            }
            else if (x == 5)
            {
                Console.WriteLine("Never argue with the data.");
            }
            else if (x == 6)
            {
                Console.WriteLine("Try not. Do or not. There is no try.");
            }
            else if (x == 7)
            {
                Console.WriteLine("You are a leaf on the wind, watch how you soar.");
            }
            else if (x == 8)
            {
                Console.WriteLine("Do absolutely nothing, and it will be everything that you thought it could be.");
            }
            else if (x == 9)
            {
                Console.WriteLine("Bow before Macky Friesch.");
            }
            else if (x == 10)
            {
                Console.WriteLine("Make it so.");
            }

        }
    }
}
