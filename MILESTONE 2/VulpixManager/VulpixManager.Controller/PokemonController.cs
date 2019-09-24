using PokemonManager.Data;
using PokemonManager.Models;
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
            while (true)
            {

                Console.WriteLine("Thanks for choosing Pokemon Manager.");
                Console.WriteLine("Please choose what to do with Pokemon. Press the corresponding number and then press enter. Press enter to continue.");
                Console.ReadLine();

                Console.WriteLine("1. Create Pokemon");
                Console.WriteLine("2. List All Pokemon");
                Console.WriteLine("3. Find Pokemon by ID");
                Console.WriteLine("4. Edit Pokemon");
                Console.WriteLine("5. Remove Pokemon");

                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        CreatePokemon();
                        break;
                    case 2:
                        DisplayPokemon();
                        break;
                    case 3:
                        SearchPokemon();
                        break;
                    case 4:
                        EditPokemon();
                        break;
                    case 5:
                        RemovePokemon();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("");
                        break;

                }
                
            }
        }
        private void CreatePokemon()
        {
            Console.WriteLine("You have chosen to create a new pokemon. What will the Pokemon's name be?");

            Pokemon pokemon = view.CreatePokemon();
            repo.Create(pokemon);


          
            
            
            // 1. Call method in view to get new pokemon info (return Pokemon) need object to hold that data
            // 2. Pass that pokemon to the repository to create
        }

        public void DisplayPokemon()
        {
            repo = new PokemonManagerRepository();
            



        }

        public int SearchPokemon()
        {
            
            Console.WriteLine("Enter an id");
            int id = int.Parse(Console.ReadLine());
            return id;
            
            // 1. Call method in view to get id from user
            // 2. Pass that id to data layer to find pokemon by that id (will get a pokemon)
            // 3. Pass pokemon to view to display
        }

        private void EditPokemon()
        {
            Console.WriteLine("Edit me.");
        }

        private void RemovePokemon()
        {
            Console.WriteLine("Remove me.");
        }

    }
}
