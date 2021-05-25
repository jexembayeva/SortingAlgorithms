using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Heap<T> where T : IComparable
    {
        private readonly List<T> items = new();
        public int Count => items.Count;

        public Heap(IEnumerable<T> items)
        {
            this.items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        private void Sort(int currentIndex)
        {
            int maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;
            while (currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < Count && items[leftIndex].CompareTo(items[maxIndex]) == -1)
                {
                    maxIndex = leftIndex;
                }
                if (rightIndex < Count && items[rightIndex].CompareTo(items[maxIndex]) == -1)
                {
                    maxIndex = rightIndex;
                }
                if (maxIndex == currentIndex)
                {
                    break;
                }
                Swap(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }
        }

        private void Swap(int currentIndex, int parentIndex)
        {
            var temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }

        public T GetMax()
        {
            var result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        public List<T> Order()
        {
            var result = new List<T>();
            while (Count > 0)
            {
                result.Add(GetMax());
            }
            return result;
        }

    }
}
