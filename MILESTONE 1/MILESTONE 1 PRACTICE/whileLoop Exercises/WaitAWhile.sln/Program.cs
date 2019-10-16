using System;

namespace WaitAWhile.sln
{
    class Program
    {
        static void Main(string[] args)
        {

        int timeNow = 9;
        int bedTime = 12;

        while (timeNow < bedTime)
            {
                Console.WriteLine("It's only " + timeNow + " o'clock!");
                Console.WriteLine("I think I'll stay up just a litttlllee longer...");
                timeNow++; // time passes
            }
            Console.WriteLine("Oh. It's " + timeNow + "o'clock!");
            Console.WriteLine("Guess I should go to bed...");




        }
    }
}
