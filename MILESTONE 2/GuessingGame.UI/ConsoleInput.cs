using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.UI
{
    public class ConsoleInput
    {
        public static int GetGuessFromUser()
        {
            Console.Clear();
            int output;
            string input;

            while(true)
            {
                Console.Write("Enter a guess between 1 and 20: ");
                input = Console.ReadLine();
                
                if(int.TryParse(input, out output))
                {
                    return output;
                }
                else
                {
                    Console.WriteLine("That was not a valid number! Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
