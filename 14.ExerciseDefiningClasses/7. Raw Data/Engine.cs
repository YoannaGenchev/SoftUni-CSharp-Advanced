using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Raw_Data
{
    public class Engine
    {
        private int speed;
        private int power;

        public int Speed
        {
            get { return this.speed; }
        }
        public int Power
        {
            get { return this.power; }
        }

        public Engine(int power, int speed)
        {
            this.power = power;
            this.speed = speed;
        }
    }
}
