using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public sealed class HeapSortAlgorithm : AlgorithmBase
    {
        protected override void Sort<T>(T[] items, IComparer<T> comparer = null)
        {
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            for (int root = items.Length / 2 - 1; root >= 0; root--)
            {
                MoveMaxToRoot(items, root, items.Length);
            }
            for (int j = items.Length - 1; j >= 0; j--)
            {
                Swap(items, 0, j);
                MoveMaxToRoot(items, 0, j);
            }
        }

        private void MoveMaxToRoot<T>(T[] items, int root, int size, IComparer<T> comparer = null)
        {
            int L = 2 * root + 1;
            int R = 2 * root + 2;
            int X = root;

            if (L < size && (comparer ?? Comparer<T>.Default).Compare(items[X], items[L]) == -1) X = L;
            if (R < size && (comparer ?? Comparer<T>.Default).Compare(items[X], items[R]) == -1) X = R;

            if (X == root)
                return;
            Swap(items, X, root);
            MoveMaxToRoot(items, X, size);
        }
    }
}
