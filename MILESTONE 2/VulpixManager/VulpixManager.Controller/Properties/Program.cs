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
            Console.ReadLine();
        }

      
    }
}
