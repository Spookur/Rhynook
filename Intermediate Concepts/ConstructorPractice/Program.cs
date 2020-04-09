using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.SetName("Whiskers");
            cat.Sound = ("Meow!");

            Animal cow = new Animal();
            cow.SetName("Alfred");
            cow.Sound = ("Moo!");

            Animal fox = new Animal("Jimmy", "Tfff!");
            

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);
            Console.WriteLine("The dog is named {0} and says {1}", cow.GetName(), cow.Sound);

            cat.Owner = "Jill";
            
            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);

            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);

            Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals);

            Console.ReadLine();

        }
    }
}
