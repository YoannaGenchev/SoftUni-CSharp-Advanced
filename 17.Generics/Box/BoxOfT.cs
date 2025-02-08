﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        private Stack<T> box;

        public BoxOfT()
        {
            box = new Stack<T>();
        }

        public void Add(T element)
        {
            box.Push(element);
        }

        public T Remove()
        {
            return box.Pop();
        }

        public int Count { get { return box.Count; } }
    }
}
