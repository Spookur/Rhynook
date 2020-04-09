using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingListAndDictionary
{
    public class Controller
    {
        public void Run()
        {
            while (true)
            {
                int menuChoice;
                if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    switch (menuChoice)
                    {
                        case 1:
                            PrintMyList();
                            break;
                        default:
                            return;
                    }
                }


                else
                {
                    Console.WriteLine("Invalid Input. Please choose the right number...");
                }

            }
        }
            public void PrintMyList()
            {
                List<string> words = new List<string>()
                {
                    "apple", "pear", "banana", "pineapple"
                };

                foreach (string word in words)

                    Console.WriteLine(word);
            }
        
    }
}
