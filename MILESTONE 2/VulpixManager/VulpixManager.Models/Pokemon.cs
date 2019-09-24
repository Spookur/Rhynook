using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonManager.Models
{
    public class Pokemon
    {
    
        
        public int Id { get; set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                 
            }
        }

        private string _pokeType;
        public string PokeType
        {
            get { return _pokeType; }
            set
            {

            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {

            }
        }

        
        public Pokemon()
        {

        }

        public void Print()
        {
            Console.WriteLine("id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Type: " + PokeType);
            Console.WriteLine("Description: " + Description);
            
        }

        
        
        
        

    }

    
   
}
