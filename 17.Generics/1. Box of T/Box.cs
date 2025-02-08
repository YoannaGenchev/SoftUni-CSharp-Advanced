using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        private List<T> list;
        public List<T> List { get { return this.list; } }
        public int Count { get { return this.list.Count; } }
        public Box()
        {
            this.list = new List<T>();
        }

        public Box(List<T> list)
        {
            this.list = list;
        }

        public void Add(T item)
        {
            this.list.Add(item);
        }

        public T Remove()
        {
            T lastElem = this.list[this.list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return lastElem;
        }
    }
}
