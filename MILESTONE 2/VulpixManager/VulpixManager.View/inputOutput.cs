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
            while (true)
            {
                Console.WriteLine("Please enter a name.");
                string _name = Console.ReadLine();
                Console.WriteLine("You have chosen " + _name + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    
                    Console.WriteLine("That's a great name. Now onto the type of Pokemon.");
                    Console.ReadLine();
                    
                    return _name;
                    
                    
                    
                }

                else 
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public string GetType(string _name)
        {
            while (true)
            {
                Console.WriteLine("Enter it's type.");
                string _pokeType = Console.ReadLine();
                Console.WriteLine(_name + "'s Type is " + _pokeType + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.WriteLine("Okay, now what about the ID number? ");
                    Console.ReadLine();
                    return _pokeType;
                }

                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public int GetInteger(string _name)
        {
            while (true)
            {
                Console.WriteLine("Choose a number that isn't already claimed by another Pokemon, then press enter.");

                string _id = Console.ReadLine();

                Console.WriteLine(_name + "'s ID number is " + _id + ". Is this the number you want? (Type y/n)");

                string correct = Console.ReadLine().ToLower();

                if (correct == "y")
                {
                    Console.WriteLine("Onto the description of " + _name + ".");
                }

                else if (correct == "n")
                {
                    Console.WriteLine("");
                }
            }
            // tryParses
        }

        public string GetDescription(string _name)
        {
            while (true)
            {
                Console.WriteLine("Describe " + _name + " then press enter.");

                string _description = Console.ReadLine();

                Console.WriteLine(_name + "'s Description is: " + _description + " //// Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();

                if (correct == "y")
                {
                    Console.WriteLine("Great, all of " + _name + "'s data will be stored. ");
                }

                else if (correct == "n")
                {
                    Console.WriteLine("");
                }
            }
        }

    }
}
