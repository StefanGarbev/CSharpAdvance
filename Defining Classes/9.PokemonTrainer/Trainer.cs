using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PokemonTrainer
{
    public class Trainer
    {
        private string name;

        private int numberOfBadges;

        public Trainer(string trainerName)
        {
            Name = trainerName;
            pokemonCollerction = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> pokemonCollerction { get; set; }

        public void filter( string element)
        { 
            
        }
    }
}
