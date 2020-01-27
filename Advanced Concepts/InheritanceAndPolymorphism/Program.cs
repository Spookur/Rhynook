using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal malcolm = new Animal()
            {
                Name = "Malcolm",
                Sound = "Hurr Hurr... Grrr RALPH!"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrr!"
            };

            grover.Sound = "Wooooooof"; // manipulates the sound from Grover, this is marked as "protected"!

            malcolm.MakeSound();

            grover.MakeSound();

            malcolm.SetAnimalIDInfo(12345, "Logan Norred");

            grover.SetAnimalIDInfo(12346, "Paul Brown");

            malcolm.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy? {0}",
                getHealth.HealthyWeight(11, 46));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Oooh Ooh Ah Ah!"

            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooof!",
                Sound2 = "Geeeeerrrr"
            };

            monkey.MakeSound();
            spot.MakeSound();
            Console.ReadLine();
        }
    }
}
