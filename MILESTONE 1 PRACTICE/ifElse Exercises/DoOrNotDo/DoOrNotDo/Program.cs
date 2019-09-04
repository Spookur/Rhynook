using System;

namespace DoOrNotDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Should I do it? (y/n) ");
            bool doIt;

            if (Console.ReadLine().Equals("y"))
            {
                doIt = true; // DO IT!
            }
            else
            {
                doIt = false; // DONT YOU DARE!
            }

            bool iDidIt = false;

            do
            {
                iDidIt = true;
                break;
            }
            while (doIt);

            if (doIt && iDidIt)
            {
                Console.WriteLine("I did it!");
            }
            else if (!doIt && iDidIt)
            {
                Console.WriteLine("I know you said not to ... but I totally did anyways.");
            }
       
        }
    }
}