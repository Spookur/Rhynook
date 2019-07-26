using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName;

            Console.WriteLine("What is the name of your dog?");
            dogName = Console.ReadLine();

            Console.WriteLine("Well then, I have this very reliable report on " + dogName + "!");
            Console.ReadLine();

            Console.WriteLine(dogName + " is:");
            Console.WriteLine("43% Bichon Frise");
            Console.WriteLine("7% Chihuahua");
            Console.WriteLine("25% Shih Tzu");
            Console.WriteLine("9% Yorkie");
            Console.WriteLine("6% Chinese Ankle Biter");
            Console.ReadLine();
        }
    }
}
