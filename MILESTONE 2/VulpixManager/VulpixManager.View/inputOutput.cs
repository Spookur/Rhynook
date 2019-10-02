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
                    Console.WriteLine("Okay, great. It will be stored!");
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

        public int GetValidID()
        {
            int _id = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Please enter the ID of the Pokemon you want to remove.");
                _id = int.Parse(Console.ReadLine());
                Console.WriteLine("You have chosen " + _id + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.WriteLine("ID number" + _id + "will be removed.");
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

        public int GetSearchId()
        {
            int _id = 0;
      

            return _id;
        }
    }

    
}
