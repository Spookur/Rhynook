using System;

namespace PickyEater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times has it been fried? (#)");
            int timesFried = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Does it have spinach on it? (y/n)");
            string hasSpinach = Console.ReadLine();


            Console.WriteLine("Is it covered in cheese? (y/n) ");
            string hasCheese = Console.ReadLine();


            Console.WriteLine("How many pats of butter are on top? (#)");
            int butterPats = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Is it covered in chocolate? (y/n)");
            string hasChocolate = Console.ReadLine();

            Console.WriteLine("Does it have a funny name? (y/n)");
            string hasFunnyName = Console.ReadLine();


            Console.WriteLine("Is it broccoli? (y/n)");
            string isBroccoli = Console.ReadLine();

            // conditionals go here

            if (hasSpinach.Equals("y") || hasFunnyName.Equals("y"))
            {
                Console.WriteLine("There's no way that'll be eaten.");
            }


        }
    }
}
