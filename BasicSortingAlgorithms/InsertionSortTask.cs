using System;

namespace SortingAlgorithms
{
    public class InsertionSortTask<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            for (int i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];
                var j = i;

                while (j > 0 && temp.CompareTo(Items[j - 1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    j--;
                }
                Items[j] = temp;
            }
        }
    }
}
