using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDoubles
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> items;

        public List<T> Items
        { 
            get { return this.items; }
            set { this.items = value; }
        }

        public Box()
        {
            this.items = new List<T>();
        }

        public override string ToString()
        {
            return string.Join("\n", this.items.Select(item => $"{item.GetType()}: {item}"));
        }

        public int GenericCountMethod(T elem)
        {
            return this.items.Count(item => item.CompareTo(elem) > 0);
        }
    }
}
