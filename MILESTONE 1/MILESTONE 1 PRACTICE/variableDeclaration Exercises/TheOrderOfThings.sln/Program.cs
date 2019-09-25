using System;

namespace TheOrderOfThings.sln
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            String opinion, size, age, shape, color, origin, material, purpose;
            String noun;

            number = 5 ;
            opinion = " Awesome ";
            size = "Teensy-Weensy ";
            age = "new ";
            shape = "oblong ";
            color = "\tbrightorange ";
            origin = "\tAlphaCentaurian ";
            material = "platinum ";
            purpose = "good ";

            noun = "dragons ";

            Console.WriteLine(number + opinion + size + age + shape + color + origin + material + purpose + noun);
        }
    }
}
