using PokemonManager.Data;
using PokemonManager.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonManager.Controller
{
    public class PokemonController
    {
        PokemonView view;
        PokemonManagerRepository repo;
        public PokemonController()
        {
            view = new PokemonView();
            repo = new PokemonManagerRepository();
        }
        public void Run()
        {


            // Call method in view to get menu choice (return int)
            // switch statement to decide which method to call (call one of the other methods in this class) 
        }

        private void CreatePokemon()
        {
            // 1. Call method in view to get new pokemon info (return Pokemon) need object to hold that data
            // 2. Pass that pokemon to the repository to create
        }

        private void DisplayPokemon()
        {

        }

        private void SearchPokemon()
        {
            // 1. Call method in view to get id from user
            // 2. Pass that id to data layer to find pokemon by that id (will get a pokemon)
            // 3. Pass pokemon to view to display
        }

        private void EditPokemon()
        {

        }

        private void RemovePokemon()
        {

        }

    }
}
