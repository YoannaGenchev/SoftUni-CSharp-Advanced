using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> list;

        public Stack()
        {
            this.list = new List<T>();
        }

        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            if (list.Count <= 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
