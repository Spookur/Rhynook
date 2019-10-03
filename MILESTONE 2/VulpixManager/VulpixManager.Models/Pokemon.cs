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
        public string Name { get; set; }
        public string PokeType { get; set; }
        public string Description { get; set; }
        
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
