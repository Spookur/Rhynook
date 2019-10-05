﻿using System;
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

        public Pokemon EditPokemonInfo()
        {
            
            Console.WriteLine("You are about to edit an existing Pokemon.");
            Pokemon pokemon = new Pokemon();
            pokemon.Name = io.GetName();
            pokemon.PokeType = io.GetType();
            pokemon.Description = io.GetDescription();
            pokemon.Id = io.GetInteger();

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
