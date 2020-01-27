using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNG
{
    class Program
    {
        static void Main(string[] args)
        {
            //int min = 0;
            //int max = 0;
            //Random random = new Random();

            //int input = int.TryParse(Console.ReadLine(), out min);

            //Console.WriteLine("Okay, " + min + " is the minimum number.");

            //int input2 = int.TryParse(Console.ReadLine()), out max;

            //Console.WriteLine("Great, " + max + " is the maximum number.");
           


            inputOutput io = new inputOutput();
            

            int minimum = io.GetMinimumNumber();
            int maximum = io.GetMaximumNumber();
            int howMany = io.HowManyNumbers();

           

            io.RandomNumberGenerator(minimum,maximum,howMany);

            
        }
    }
}
