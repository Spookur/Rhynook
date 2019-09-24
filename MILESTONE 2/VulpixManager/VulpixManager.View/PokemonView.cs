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
        inputOutput io = new inputOutput();




        public Pokemon CreatePokemon()
        {
            
            Pokemon pokemon = new Pokemon();
            
            pokemon.Name = io.GetName();
            pokemon.PokeType = io.GetType();
            pokemon.Description = io.GetDescription();
            pokemon.Id = io.GetInteger();


            // repeat above line for each 
            return pokemon;
        }
        public void GetNewPokemonInfo()
        {

        }

        public void DisplayPokemon()
        {
            inputOutput io = new inputOutput();
            Pokemon pokemon = new Pokemon();
            PokemonManagerRepository repo = new PokemonManagerRepository();
            pokemon.Print();
            repo.ReadAll();
           

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
