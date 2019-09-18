using PokemonManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonManager.Data
{
    public class PokemonManagerRepository
    {

        public static List<Pokemon> data;

        public PokemonManagerRepository()
        {
            if (data == null)
            {
                data = new List<Pokemon>();
            }
        }
        public Pokemon Create(Pokemon input)
        {
            return new Pokemon();
        }

        public List<Pokemon> ReadAll()
        {
            return data;
        }

        public Pokemon ReadByID(int id) // use looping
        {
            return new Pokemon(); 
        }

        public void Update(int id)
        {
            
        }

        public void Delete(int id)
        {
            
        }
    }
}
