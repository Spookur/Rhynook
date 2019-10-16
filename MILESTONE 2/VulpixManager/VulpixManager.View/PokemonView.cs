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
        PokemonManagerRepository repo = new PokemonManagerRepository();
        private inputOutput io = new inputOutput();




        public Pokemon CreatePokemon() // stores what the user entered
        {
            Pokemon pokemon = new Pokemon();

            pokemon.Name = io.GetName();
            pokemon.PokeType = io.GetType();
            pokemon.Description = io.GetDescription();
            pokemon.Id = io.GetInteger();

            return pokemon;
        }

        public void DisplayPokemon(Pokemon pokemon)
        {
                pokemon.Print(); // call the Print method in the Pokemon class
            
            
        }

        public int SearchPokemon() // STEP 3
        {

            Pokemon pokemon = new Pokemon();


            return io.GetSearchId();
        }

        public int EditPokemonInfo()
        {

            Console.WriteLine("You are about to edit an existing Pokemon.");
            Pokemon pokemon = new Pokemon();

            return io.GetIDForUpdate();     
        }

        public Pokemon NewPokemonInfo()
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Name = io.GetNewName();
            pokemon.PokeType = io.GetNewType();
            pokemon.Description = io.GetNewDescription();
            pokemon.Id = io.GetNewInteger();

            return pokemon;

        }

        public Pokemon ConfirmRemovePokemon()
        {
            Pokemon pokemon = new Pokemon();

            pokemon.Id = io.GetValidID();

            return pokemon;

        }


    }
}
