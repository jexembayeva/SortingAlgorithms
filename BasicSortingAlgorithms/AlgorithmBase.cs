using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public abstract class AlgorithmBase
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> items) => Sort(items, null);

        public IEnumerable<T> Sort<T>(IEnumerable<T> items, IComparer<T> comparer)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            if (!items.Any())
            {
                return Enumerable.Empty<T>();
            }

            var itemsArr = items.ToArray();
            Sort(itemsArr, comparer);

            return itemsArr;
        }

        protected abstract void Sort<T>(T[] items, IComparer<T> comparer = null);

        protected static void Swap<T>(T[] items, int positionA, int positionB)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            if (positionA < items.Length && positionB < items.Length)
            {
                var temp = items[positionA];
                items[positionA] = items[positionB];
                items[positionB] = temp;
            }
        }
    }
}
