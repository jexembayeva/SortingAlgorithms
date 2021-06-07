using System.Collections.Generic;

namespace SortingAlgorithms
{
    public sealed class ShellSortAlgorithm : AlgorithmBase
    {
        protected override void Sort<T>(T[] items, IComparer<T> comparer = null)
        {
            var step = items.Length / 2;
            while (step > 0)
            {
                for (int i = step; i < items.Length; i++)
                {
                    int j = i;
                    
                    while ((j >= step) && (comparer ?? Comparer<T>.Default).Compare(items[j - step], items[j]) == 1)
                    {
                        Swap(items, j - step, j);
                        j -= step;

                    }
                }
                step/=2;
            }
        }

        public void Sort<T>(T[] items)
        {
            int k = 1;
            var step = 1;
            while (step < (items.Length / 3))
            {
                for (int i = step; i < items.Length; i++)
                {
                    int j = i;
                    while ((j >= step) && Comparer<T>.Default.Compare(items[j - step], items[j]) == 1)
                    {
                        Swap(items, j - step, j);
                        j -= step;

                    }
                }
                k++;
                step = ((3 ^ k) - 1) / 2;
            }
        }
    }
}
