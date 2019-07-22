using System;

namespace BirthStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int March = 3;
            int February = 2;
            int January = 1;
            int userGuess = 0;

            while (userGuess != January)
            {
                Console.Write("Enter your birthmonth: ");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess == January)
                {
                    Console.WriteLine("Garnet");
                }
                else if (userGuess == February)
                {
                    Console.WriteLine("Amethyst");
                    break;
                }
                else if (userGuess == March)
                {
                    Console.WriteLine("Aquamarine");
                    break;
                }
            }
        }





    }
}

