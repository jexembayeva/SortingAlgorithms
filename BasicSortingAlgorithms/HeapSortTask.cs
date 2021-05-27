using System;

namespace SortingAlgorithms
{
    public class HeapSortTask<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            for (int root = Items.Length / 2 - 1; root >= 0; root--)
            {
                MoveMaxToRoot(root, Items.Length);
            }
            for (int j = Items.Length - 1; j >= 0; j--)
            {
                Swap(0, j);
                MoveMaxToRoot(0, j);
            }
        }

        private void MoveMaxToRoot(int root, int size)
        {
            int L = 2 * root + 1;
            int R = 2 * root + 2;
            int X = root;
            if (L < size && Items[X].CompareTo(Items[L]) == -1) X = L;
            if (R < size && Items[X].CompareTo(Items[R]) == -1) X = R;

            if (X == root)
                return;
            Swap(X, root);
            MoveMaxToRoot(X, size);
        }
    }
}
