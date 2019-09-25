using System;

namespace CoinFlippin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ready, set, flip!!");

            Random coinFlipper = new Random();
            int flipResult = coinFlipper.Next(2) + 1;

            Console.WriteLine("It's time to flip a coin, ladies and gentlemen.");

            if (flipResult == 1)
            {
                Console.WriteLine("You flipped heads!!");
            }
            else if (flipResult == 2)
            {
                Console.WriteLine("You got tails!!");
            }
        }
    }
}
