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

        public void Run() // the main menu with the 5 options
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
        private void CreatePokemon() // case 1 executes this
        {
            Console.WriteLine("You have chosen to create a new pokemon. What will the Pokemon's name be?");

            Pokemon pokemon = view.CreatePokemon(); // called method in view to get new pokemon info ---> PokemonView.cs
            repo.Create(pokemon); // passed the pokemon to the repository
        }

        public void DisplayPokemon() // case 2 executes this
        {
            List<Pokemon> pokeList = repo.ReadAll(); // new instance of the list of Pokemon, set it equal to the data in the repository

            Console.Clear();
            
            for (int i = 0; i < pokeList.Count; i++) // files through the list of Pokemon that have been created
            {
                
                view.DisplayPokemon(pokeList[i]); // calls the Display method in the view and passes in the list
                
                
            }
        }

        public void SearchPokemon() // case 3 executes this
        {

            Pokemon pokemon = view.SearchPokemon();
            repo.ReadByID(pokemon.Id);
           
            pokemon.Print();
            
        }

        private void EditPokemon() // case 4 executes this
        {
            Console.WriteLine("Edit me.");
        }

        private void RemovePokemon() // case 5 executes this
        {
            Pokemon pokemon = view.ConfirmRemovePokemon();
            repo.Delete(pokemon.Id);
        }

    }
}
