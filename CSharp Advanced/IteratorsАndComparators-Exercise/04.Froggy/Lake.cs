using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    public class Lake<T> : IEnumerable<int>
    {
        List<int> stones;
        public Lake(IEnumerable<int> lakeStones)
        {
            stones = new List<int>(lakeStones);
        }

        public Lake()
        {
            stones = new List<int>();
        }

        public void JumpEven(List<int> even)
        {
            for (int i = 0; i < even.Count; i++)
            {
                stones.Add(even[i]);
            }
        }

        public void JumpOdd(List<int> odd)
        {
            for (int i = odd.Count - 1; i >= 0; i--)
            {
                stones.Add(odd[i]);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i++)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", stones);
        }
    }
}
