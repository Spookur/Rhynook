using System;

namespace RollerCoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We're going to go on a roller coaster...");
            Console.WriteLine("Let me know when you want to get off...");

            String keepRiding = "y";
            int loopsLooped = 0;
            while (keepRiding.Equals("y"))
            {

                Console.WriteLine("WHEEEEEEEEEEEEeeeeeEEEEEE............!!!");
                Console.WriteLine("Want to keep going? (y/n) :");
                keepRiding = Console.ReadLine().ToLower();

                if (keepRiding != "y" && keepRiding != "n")
                {
                    Console.WriteLine("Invalid entry!"); //not sure why this doesn't continue...
                    continue;
                }

                if (keepRiding == "n")
                    break;

                loopsLooped++;
            }




            Console.WriteLine("Wow, that was FUN!");
            Console.WriteLine("We looped that loop " + loopsLooped + " times!!");
        }
    }
}
