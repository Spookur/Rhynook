using System;

namespace BirdsInPie
{
    class Program
    {
        static void Main(string[] args)
        {
            int birdsInPie = 0;
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("Blackbird #" + i + " goes into the pie!");
                birdsInPie++;
            }

            Console.WriteLine("There are " + birdsInPie + " birds in there! Holy Shnikees.");
            Console.WriteLine("Quite the pie full, eh?");
        }
    }
}
