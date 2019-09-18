using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonManager.Models
{
    public class Pokemon
    {
        public int id;
        public string Title;
        public int ReleaseYear;
        public string Director;
        public float Rating;

        public Pokemon()
        {
          

        }

        public Pokemon(int _id, string _title, int _releaseYear, string _director, float _rating)
        {
            id = _id;
            Title = _title;
            ReleaseYear = _releaseYear;
            Director = _director;
            Rating = _rating;
        }

        public void Print()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Release Year: " + ReleaseYear);
            Console.WriteLine("Director: " + Director);
            Console.WriteLine("Rating: " + Rating);
        }

        Pokemon vulpix = new Pokemon();
        
        
        

    }

    
   
}
