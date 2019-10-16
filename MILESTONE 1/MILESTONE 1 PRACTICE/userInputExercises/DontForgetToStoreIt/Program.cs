using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontForgetToStoreIt
{
    class Program
    {
        static void Main(string[] args)
        {
            string meaningOfLifeAndEverything;
            double pi = 3.14159;
            String cheese, color;
            

            Console.WriteLine("Give me pi to at least 5 decimals: ");
            pi = Convert.ToDouble(Console.ReadLine());

            // We've got Convert.ToDouble down but meaningOfLifeAndEverything is an INT
            // so we'll have to use Convert.ToInt32
            Console.WriteLine("What is the meaning of life, the universe, and everything? ");
            meaningOfLifeAndEverything = Console.ReadLine();

                if (meaningOfLifeAndEverything == "silence my brother")
                {
                    Console.WriteLine("Welcome to the Dark Brotherhood.");
                }
                else
                {
                Console.WriteLine("Please continue.");
                }

            Console.WriteLine("What is your favorite kind of cheese? ");
            cheese = Console.ReadLine();

            Console.WriteLine("Do you like the color red or blue more? ");
            color = Console.ReadLine();

            Console.WriteLine("Ooh, " + color + " " + cheese +" sounds delicious!");
            Console.WriteLine("The circumference of life is " +( 2 * pi));
            Console.ReadLine();
        }
    }

}
