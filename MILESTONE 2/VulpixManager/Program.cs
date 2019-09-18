using PokemonManager.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PokemonManager
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonController controller = new PokemonController();
            controller.Run();
        }

        public static void Run()
        {
            Console.WriteLine("Thanks for choosing Pokemon Manager.");
            Console.WriteLine("Please choose what to do with Pokemon. Press the corresponding number and then press enter. Press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("1. Create Pokemon");
            Console.WriteLine("2. List All Pokemon");
            Console.WriteLine("3. Find Pokemon by ID");
            Console.WriteLine("4. Edit Pokemon");
            Console.WriteLine("5. Remove Pokemon");
            Console.ReadLine();
        }
    }
}
