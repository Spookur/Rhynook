using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulpixManager.View
{
    public class inputOutput
    {
        public string GetName()
        {
            string _name = "";
            bool validInput = false;

            while (!validInput)
            {
                
                Console.WriteLine("Please enter a name.");
                _name = Console.ReadLine();
                Console.WriteLine("You have chosen " + _name + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.WriteLine("Okay, now what about the Type? ");
                    
                    validInput = true;

                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            return _name;
        }

        public string GetType()
        {
            string _pokeType = "";
            bool validInput = false;

            while (!validInput)
            {

                Console.WriteLine("Please enter a type.");
                _pokeType = Console.ReadLine();
                Console.WriteLine("You have chosen " + _pokeType + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.WriteLine("Okay, now what about the description? ");
                    
                    validInput = true;

                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            return _pokeType;

        }


        public string GetDescription()
        {
            string _description = "";
            bool validInput = false;

            while (!validInput)
            {

                Console.WriteLine("Please enter a description.");
                _description = Console.ReadLine();
                Console.WriteLine("You have chosen " + _description + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.WriteLine("Okay, now what about the ID? ");
                    
                    validInput = true;

                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            return _description;

        }

        public int GetInteger()
        {
            int _id = 0;
            bool validInput = false;
            

            while (!validInput)
            {
                

                Console.WriteLine("Please enter an ID.");
                validInput = int.TryParse(Console.ReadLine(), out _id);
                Console.WriteLine("You have chosen " + _id + ". Is that correct? (Type y/n)");
                
                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.Clear();
                    Console.WriteLine("Okay, great. It will be stored! Press Enter to continue.");
                    Console.WriteLine("");
                    Console.ReadLine();
                    validInput = true;

                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                    validInput = false;
                }

            }

            return _id;

        }

        public int GetValidID() // prompt from RemovePokemon()
        {
            int _id = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Please enter the ID of the Pokemon you want to remove.");
                validInput = int.TryParse(Console.ReadLine(), out _id);
                Console.WriteLine("Are you sure you want to remove the Pokemon under the ID number: " + _id + "? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.WriteLine("That Pokemon will be removed.");
                    Console.WriteLine("");
                    validInput = true;

                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                    validInput = false;
                }

            }

            return _id;
        }

        public int GetSearchId() // prompt from SearchPokemon()
        {
            int _id = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Please enter the ID of an existing Pokemon.");
                validInput = int.TryParse(Console.ReadLine(), out _id);
                Console.WriteLine("You have chosen " + _id + ". Is that correct? (Type y/n)");
                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.Clear();
                    Console.WriteLine("Attempting to display: " + _id + "...");
                    Console.WriteLine("");
                    
                    validInput = true;
                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                }


            }
      

            return _id;
        }

        public int GetIDForUpdate() // prompt for updating
        {
            int _id = 0;
            bool validInput = false;

            while (!validInput)
            {
                
                Console.WriteLine("Please enter the ID of the Pokemon you want to edit.");
                validInput = int.TryParse(Console.ReadLine(), out _id);
                Console.WriteLine("You have chosen " + _id + ". Is that correct? (Type y/n)");
                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.Clear();
                    Console.WriteLine("Okay, time to edit Pokemon number " + _id + "...");
                    Console.WriteLine("");

                    Console.WriteLine("Attempting to Display Pokemon number " + _id + "...");
                    Console.WriteLine("");

                    validInput = true;
                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                }


            }


            return _id;
        }

        public string GetNewName()
        {
            string _name = "";
            bool validInput = false;

            while (!validInput)
            {

                Console.WriteLine("Please enter a new name.");
                _name = Console.ReadLine();
                Console.WriteLine("You have chosen " + _name + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.WriteLine("Okay, now what about the Type? ");

                    validInput = true;

                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            return _name;
        }

        public string GetNewType()
        {
            string _pokeType = "";
            bool validInput = false;

            while (!validInput)
            {

                Console.WriteLine("Please enter a type.");
                _pokeType = Console.ReadLine();
                Console.WriteLine("You have chosen " + _pokeType + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.WriteLine("Okay, now what about the description? ");

                    validInput = true;

                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            return _pokeType;

        }


        public string GetNewDescription()
        {
            string _description = "";
            bool validInput = false;

            while (!validInput)
            {

                Console.WriteLine("Please enter a description.");
                _description = Console.ReadLine();
                Console.WriteLine("You have chosen " + _description + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.WriteLine("Okay, now what about the ID? ");

                    validInput = true;

                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            return _description;

        }

        public int GetNewInteger()
        {
            int _id = 0;
            bool validInput = false;


            while (!validInput)
            {


                Console.WriteLine("Please enter an ID.");
                validInput = int.TryParse(Console.ReadLine(), out _id);
                Console.WriteLine("You have chosen " + _id + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.WriteLine("Okay, great. It will be stored!");
                    Console.ReadLine();
                    validInput = true;

                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                    
                }

            }

            return _id;

        }


    }

    
}
