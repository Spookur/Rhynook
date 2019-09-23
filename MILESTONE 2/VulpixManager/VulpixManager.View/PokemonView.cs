using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonManager.Models;
using PokemonManager.View;
using VulpixManager.View;

namespace PokemonManager.View
{
    public class PokemonView
    {
        int result;

        



        public Pokemon CreatePokemon()
        {
            inputOutput io = new inputOutput();
            Pokemon pokemon = new Pokemon();
            pokemon.Name = io.GetName();
            
            pokemon.Description = io.GetName();
            // repeat above line for each 
            return pokemon;
        }
        public void GetNewPokemonInfo()
        {

        }

        public void DisplayPokemon()
        {

        }

        public int SearchPokemon()
        {
            Console.WriteLine("Enter an id");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public bool ConfirmRemovePokemon()
        {
            return true;
        }


    }
}
