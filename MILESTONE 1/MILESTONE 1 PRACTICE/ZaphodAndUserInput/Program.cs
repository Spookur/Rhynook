using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaphodAndUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string color;
            string fruit;
            int number;

            Console.WriteLine("Hello there!");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + " my name is Herschel. What is your favorite color, " + name + "?");

            color = Console.ReadLine();

            Console.WriteLine("Huh? Mine is Electric Lime.");

            

            Console.WriteLine("I really like limes. They're my favorite fruit too.");

            Console.WriteLine("What's YOUR favorite fruit " + name + " ?");

            fruit = Console.ReadLine();

            Console.WriteLine("Really?! " + fruit + "That's wild!");

            Console.WriteLine("Okay, so speaking of favorites, what's your favorite number?");

            number = Convert.ToInt32(Console.ReadLine().ToUpper());

            Console.WriteLine("OOH, " + number + "that's a great number. Mine's -7.");

            Console.WriteLine("Did you know that " + number + " * -7 is" + number * -7 + " ?");

            Console.WriteLine("That's a pretty cool number too!");

            Console.WriteLine("Thanks for talking to me, " + name);

            Console.WriteLine("Press any key to exit the console.");

            Console.ReadLine();

            

            
            







        }
    }
}
