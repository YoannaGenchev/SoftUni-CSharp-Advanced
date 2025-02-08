using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class MyTuple<T,P,Q>
    {
        private T item1;
        private P item2;
        private Q item3;

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

        public Q Item3
        {
            get { return item3; }
            set { item3 = value;  }
        }

        public MyTuple(T item1, P item2, Q item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return $"{item1.ToString()} -> {item2.ToString()} -> {item3.ToString()}";
        }
    }
}
