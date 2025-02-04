using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Car_Salesman
{
    internal class Car
    {
        public string Model { get; }
        public Engine Engine { get; }
        public int? Weight { get; }
        public string? Color { get; }

        public Car(string model, Engine engine, int? weight, string? color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine(this.Engine.ToString());
            sb.AppendLine($" Weight: {this.Weight?.ToString() ?? "n/a"}");
            sb.Append($" Color: {this.Color ?? "n/a"}");
            
            return sb.ToString();
        }
    }
}
