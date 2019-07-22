using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADifferentKettleOfFish
{
    class Program
    {
        static void Main(string[] args)
        {
            int fish = 1;

            while (fish < 10)
            {
                if (fish == 3)
                {
                    Console.WriteLine("Red fish!");
                }
                else if (fish == 4)
                {
                    Console.WriteLine("Blue fish!");
                }
                else
                {
                    Console.WriteLine(fish + " fish!");
                }

                fish++;

                Console.ReadLine();
                 
            }
        }
    }
}
