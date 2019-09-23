using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonManager.Models
{
    public class Pokemon
    {
        public int Id;
        public string Name;
        public int PokeType;
        public string Description;
        public float Rating;

        public Pokemon()
        {

        }

        public Pokemon(int _id, string _name, int _pokeType, string _description, float _rating)
        {
            Id = _id;
            Name = _name;
            PokeType = _pokeType;
            Description = _description;
            Rating = _rating;
        }

        public void Print()
        {
            Console.WriteLine("id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Type: " + PokeType);
            Console.WriteLine("Director: " + Description);
            Console.WriteLine("Rating: " + Rating);
        }

        
        
        
        

    }

    
   
}
