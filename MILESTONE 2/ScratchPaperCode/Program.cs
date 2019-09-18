using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPaperCode
{
    public class Program
    {
        static void Main(string[] args)
        {

            string name;

            Console.WriteLine("Welcome to a GAME.");
            Console.WriteLine("(also keep in mind that you can always press the enter key to move onto the next line.");
            Console.ReadLine();
            Console.WriteLine("Choose a mode. Enter either: \"easy\" or \"hard\"");

            name = Console.ReadLine();

    


            if (name == "easy")
            {
                Console.WriteLine("You have chosen easy mode, wimp.");
                Console.ReadLine();

            }

            if (name == "hard")
            {
                Console.WriteLine("Welcome to hard mode.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Invalid input.");
                Console.ReadLine();

            }

            string meaningOfLifeAndEverything;

            Console.WriteLine("What is the meaning of life, the universe, and everything? ");
            meaningOfLifeAndEverything = Console.ReadLine();

            if (meaningOfLifeAndEverything == "silence my brother")
            {
                Console.WriteLine("Welcome to the Dark Brotherhood.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please continue.");
            }
        }




    }
}
