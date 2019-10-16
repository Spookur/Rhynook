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
                Console.WriteLine("Please choose what to do with Pokemon. Press the corresponding number and then press enter.");
                Console.WriteLine("");

                Console.WriteLine("1. Create Pokemon");
                Console.WriteLine("2. List All Pokemon");
                Console.WriteLine("3. Find Pokemon by ID");
                Console.WriteLine("4. Edit Pokemon");
                Console.WriteLine("5. Remove Pokemon");
                int menuChoice;
                if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
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

                else
                {
                    Console.WriteLine("Invalid Input. Please Choose a number 1-5 and press enter.");
                    Console.WriteLine("");
                }



            }
        }
        private void CreatePokemon() // case 1 executes this
        {


            Pokemon pokemon = view.CreatePokemon(); // called method in view to get new pokemon info ---> PokemonView.cs
            repo.Create(pokemon); // passed the pokemon to the repository
        }

        public void DisplayPokemon() // case 2 executes this
        {
            List<Pokemon> pokeList = repo.ReadAll(); // new instance of the list of Pokemon, set it equal to the data in the repository
            Console.Clear();

            if (pokeList.Count == 0)
            {
                Console.WriteLine("There are no Pokemon to display! Press enter to continue.");


                Console.ReadLine();
            }

            else

            {
                for (int i = 0; i < pokeList.Count; i++)
                {
                    view.DisplayPokemon(pokeList[i]);
                }

            }
        }

        public void SearchPokemon() // case 3 executes this
        {

            int searchId = view.SearchPokemon();
            Pokemon pokemon = repo.ReadByID(searchId);
            pokemon.Print();
        }

        private void EditPokemon() // case 4 executes this
        {
<<<<<<< HEAD
            Pokemon pokemon = view.EditPokemonInfo();



            repo.Delete(pokemon.Id);
            CreatePokemon();
            Console.Clear();



=======
            Console.Clear();
            int editId = view.EditPokemonInfo(); // returns user id 
            Pokemon pokemon = repo.ReadByID(editId); // id is equal to corresponding Pokemon from repo
            pokemon.Print(); // displays the Pokemon
            Pokemon newPokemon = view.NewPokemonInfo();
            // try newPokemon = pokemon
            repo.Update(pokemon.Id, newPokemon.Name, newPokemon.PokeType, newPokemon.Description, newPokemon.Id);
            
            
            
              
>>>>>>> 4ba0b673178d81a655f310af50aa806df3a5d995
        }

        private void RemovePokemon() // case 5 executes this
        {
            Console.Clear();
            Pokemon pokemon = view.ConfirmRemovePokemon();
            repo.Delete(pokemon.Id);

        }

    }
}
