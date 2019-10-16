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
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Thanks for choosing Pokemon Manager! Choose what to do with Pokemon. ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            PokemonController controller = new PokemonController(); // create a new instance of controller
            controller.Run(); // execute the Run method in the controller
            
            



               
            
        }

      
    }
}
