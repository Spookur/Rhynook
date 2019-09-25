using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonManager.Data;
using PokemonManager.Models;
using PokemonManager.View;
using VulpixManager.View;

namespace PokemonManager.View
{
    public class PokemonView
    {
        int result;
        private inputOutput io = new inputOutput();




        public Pokemon CreatePokemon() // stores what the user entered
        {
            
            Pokemon pokemon = new Pokemon();

            // goes through each of these prompts in the inputOutput class to get user input
            
            pokemon.Name = io.GetName();
            pokemon.PokeType = io.GetType();
            pokemon.Description = io.GetDescription();
            pokemon.Id = io.GetInteger();

            return pokemon;
        }
        public void GetNewPokemonInfo()
        {

        }

        public void DisplayPokemon(Pokemon pokemon)
        {

            pokemon.Print();
            
           

        }

        public void SearchPokemon(Pokemon pokemon) // STEP 3
        {
            pokemon.Print();
        }

        public bool ConfirmRemovePokemon()
        {
            return true;
        }


    }
}
