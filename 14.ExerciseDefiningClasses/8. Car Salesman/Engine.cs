using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Car_Salesman
{
    internal class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string? efficiency;

        public string Model { get; }
        public int Power { get; }
        public int? Displacement { get; }
        public string? Efficiency { get; }

        public Engine(string model, int power, int? displacement, string? efficency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficency;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  {this.Model}:");
            sb.AppendLine($"    Power: {this.Power}");
            sb.AppendLine($"    Displacement: {this.Displacement?.ToString() ?? "n/a"}");
            sb.Append($"    Efficiency: {this.Efficiency ?? "n/a"}");

            return sb.ToString();
        }
    }
}
