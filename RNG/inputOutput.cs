using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNG
{
    public class inputOutput
    {
        public int GetMinimumNumber()
        {
            int min = 0;
            
            bool validInput = false;


            while (!validInput)
            {


                Console.WriteLine("Please enter a minimum number.");
                validInput = int.TryParse(Console.ReadLine(), out min);
                Console.WriteLine("You have chosen " + min + ". Is that correct? (Type y/n)");

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

            return min;

        }

        public int GetMaximumNumber()
        {
            int max = 0;
            bool validInput = false;


            while (!validInput)
            {


                Console.WriteLine("Please enter a maximum number.");
                validInput = int.TryParse(Console.ReadLine(), out max);
                Console.WriteLine("You have chosen " + max + ". Is that correct? (Type y/n)");

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

            return max;

        }

        public int HowManyNumbers()
        {
            int howMany = 0;
            bool validInput = false;


            while (!validInput)
            {


                Console.WriteLine("How many random numbers do you want to display?");
                validInput = int.TryParse(Console.ReadLine(), out howMany);
                Console.WriteLine("You have chosen " + howMany + ". Is that correct? (Type y/n)");

                string correct = Console.ReadLine().ToLower();
                if (correct == "y")
                {
                    Console.Clear();
                    Console.WriteLine("Press Enter to display your number(s).");
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

            return howMany;
        }

        public void RandomNumberGenerator(int minimum, int maximum, int howMany)
        {
            
            while(true)
            {
                Random rng = new Random();
                int min = minimum;
                int max = maximum;
                int hm = howMany;

                for (int i = 0; i < hm; i++)
                {
                    Console.Write(rng.Next(min, max) + ", ");
                }
                Console.WriteLine();
                Console.WriteLine("Press enter for {0} new random numbers.", howMany);

                Console.ReadLine();

            }
            

        }
    }
    
}
