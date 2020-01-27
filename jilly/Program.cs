using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jilly
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allNumbers = new List<int>()
            { 5, 7, 34, 23, 8, 10 };

            List<int> onlyOdds = new List<int>();

            foreach (int number in allNumbers)
            {
                if (number % 2 == 1)
                    onlyOdds.Add(number);

                Console.ReadLine();
            }
        }
    }
}
