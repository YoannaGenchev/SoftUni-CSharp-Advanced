using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class MyTuple<T,P>
    {
        private T item1;
        private P item2;

        public T Item1
        {
            get { return item1; }
            set { item1 = value; }
        }

        public P Item2
        {
            get { return item2; }
            set { item2 = value; }
        }

        public MyTuple(T item1, P item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public override string ToString()
        {
            return $"{item1.ToString()} -> {item2.ToString()}";
        }
    }
}
