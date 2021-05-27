using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class AlgorithmBase<T>
        where T : IComparable
    {
        public T[] Items { get; set; }
        protected void Swap(int positionA, int positionB)
        {
            if (positionA < Items.Length && positionB < Items.Length)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
            }
        }

        public virtual void Sort()
        {
        }
    }
}
