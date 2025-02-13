using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> list;
        private int index = 0;

        public ListyIterator(List<T> list)
        { 
            this.list = list;
        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            return index + 1 < list.Count;
        }

        public void Print()
        {
            if (list.Count > 0)
            {
                Console.WriteLine(list[index]);
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }
    }
}
