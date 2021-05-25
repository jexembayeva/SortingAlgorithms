using System;

namespace SortingAlgorithms
{
    public class ShellSortTask<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var step = Items.Count / 2;
            while (step > 0)
            {
                for (int i = step; i < Items.Count; i++)
                {
                    int j = i;
                    while ((j >= step) && Items[j - step].CompareTo(Items[j]) == 1)
                    {
                        Swap(j - step, j);
                        j -= step;

                    }
                }
                step/=2;
            }
        }

        public void Sort2()
        {
            int k = 1;
            var step = 1;
            while (step < (Items.Count / 3))
            {
                for (int i = step; i < Items.Count; i++)
                {
                    int j = i;
                    while ((j >= step) && Items[j - step].CompareTo(Items[j]) == 1)
                    {
                        Swap(j - step, j);
                        j -= step;

                    }
                }
                k++;
                step = ((3 ^ k) - 1) / 2;
            }
        }
    }
}
