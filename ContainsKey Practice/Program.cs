using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsKey_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> items = new Dictionary<string, string>();

            string key;
            string value;

            while (true)
            {
                Console.Write("Enter a key:");
                key = Console.ReadLine();

                if (items.ContainsKey(key))
                {
                    Console.WriteLine("That key already exists!");
                    continue;
                }

                Console.WriteLine("Enter a value:");
                value = Console.ReadLine();

                items.Add(key, value);

                string input;

                Console.WriteLine("Enter a sentence:");
                input = Console.ReadLine();

                Dictionary<char, int> letterCounts = new Dictionary<char, int>();

                foreach (char c in input)
                {
                    // do we already have this letter?
                    if (letterCounts.ContainsKey(c))
                    {
                        letterCounts[c]++;
                    }

                    else
                    {
                        // first time we have had this letter
                        letterCounts.Add(c, 1);
                    }
                }
            }
        }
    }
}
