using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._Pokemon_Trainer
{
    internal class Trainer
    {
        public string Name { get; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; } = new List<Pokemon>();
        public Trainer(string name)
        {
            this.Name = name;
        }
    }
}
