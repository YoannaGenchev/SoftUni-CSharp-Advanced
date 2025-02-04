using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._Pokemon_Trainer
{
    internal class Pokemon
    {
        public string Name { get; }
        public string Element { get; }
        public int Health { get; set; }
        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
    }
}
