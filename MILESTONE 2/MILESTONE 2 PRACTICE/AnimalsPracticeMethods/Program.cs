using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsPracticeMethods
{

    class Animal
    {
        // CLASS VARIABLES

        public static int Count = 0;

        public string name;
        public int age;
        public double happiness;

        // CLASS CONSTRUCTORS

        //public Animal()
        //{
        //    name = "Spotty";
        //    age = 6;
        //    happiness = 0.5;

        //    Count++;
        //}

        public Animal()
        {

        }

        public Animal(string _name, int _age, double _happiness)
        {
            name = _name;
            age = _age;
            happiness = _happiness;

            Count++;
        }

        // CLASS METHODS

         public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }

    }
    public class MainClass
    {
        public static void Main(string[] args)
        {
           
            Animal dog = new Animal();

            dog.name = "Spotty";
            dog.age = 6;
            dog.happiness = 0.5;

            dog.Print();

            Animal dog2 = new Animal();

            dog.name = "Ralph";
            dog.age = 9;
            dog.happiness = 0.2;

            dog.Print();

           


            Console.WriteLine();

            dog2.name = Console.ReadLine();
            dog2.age = int.Parse(Console.ReadLine());
            dog2.happiness = 0.6; // user input
            Animal cat = new Animal("Mr. Beans", 10, 0.8);
            cat.Print();

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double happiness = 0.6; // user input

            Animal cat2 = new Animal(name, age, happiness);

            Animal cat3 = new Animal(name, age, happiness);

            Console.WriteLine();

            Console.WriteLine("Number of animals: " + Animal.Count);
            
            
            Console.ReadKey();
        }
    }
}
