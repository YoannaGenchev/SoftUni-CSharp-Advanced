using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
            SortStones();
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in stones)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void SortStones()
        {
            var firstStones = new List<int>();
            var secondStones = new List<int>();
            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    firstStones.Add(stones[i]);
                }
                else
                {
                    secondStones.Add(stones[i]);
                }
            }

            secondStones.Reverse();

            this.stones = firstStones;
            this.stones.AddRange(secondStones);
        }
    }
}
