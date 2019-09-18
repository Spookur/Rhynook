using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG.ConsoleUtilities.BLL
{
    public class UserInput
    {
        public static int GetIntFromUser(string prompt)
        {
            int result;
            string userInput;

            // loop until we return an int
            while (true)
            {
                // 1 & 2: Prompt and Read
                Console.Write(prompt);
                userInput = Console.ReadLine();

                // attempt to convert
                if (int.TryParse(userInput, out result))
                {
                    // good input
                    return result;
                }

                // bad input
                Console.WriteLine("That is not a valid input.");
            }
        }
    }
}