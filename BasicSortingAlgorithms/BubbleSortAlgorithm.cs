using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public sealed class BubbleSortAlgorithm : AlgorithmBase
    {
        protected override void Sort<T>(T[] items, IComparer<T> comparer = null)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            var count = items.Length;
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    var a = items[i];
                    var b = items[i + 1];

                    if ((comparer ?? Comparer<T>.Default).Compare(a, b) == 1)
                    {
                        Swap(items, i, i + 1);
                    }
                }
            }
        }
    }
}
