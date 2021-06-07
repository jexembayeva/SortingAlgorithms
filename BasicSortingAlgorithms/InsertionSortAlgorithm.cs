using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public sealed class InsertionSortAlgorithm : AlgorithmBase
    {
        protected override void Sort<T>(T[] items, IComparer<T> comparer = null)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            for (int i = 1; i < items.Length; i++)
            {
                var temp = items[i];
                var j = i;

                while (j > 0 && (comparer ?? Comparer<T>.Default).Compare(temp, items[j - 1]) == -1)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = temp;
            }
        }
    }
}
