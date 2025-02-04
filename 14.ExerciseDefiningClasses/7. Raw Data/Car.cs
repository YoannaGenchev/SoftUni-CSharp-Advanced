using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Raw_Data
{
    public class Car
    {
        public string Model { get; }
        public Engine Engine { get; }
        public Cargo Cargo { get; }
        public IReadOnlyCollection<Tire> Tires { get; }

        public Car(string model, Engine engine, Cargo cargo, params Tire[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = new List<Tire>(tires).AsReadOnly();
        }
    }
}
