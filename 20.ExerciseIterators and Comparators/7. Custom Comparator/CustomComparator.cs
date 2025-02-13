using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomComparator
{
    public class CustomComparator : IComparer<int>
    {
        private bool IsEven(int x) { return x % 2 == 0; }
        public int Compare(int x, int y)
        {
            if (IsEven(x) && false == IsEven(y))
            {
                return -1;
            }

            if (false == IsEven(x) && IsEven(y))
            {
                return 1;
            }

            return x.CompareTo(y);
        }
    }
}
