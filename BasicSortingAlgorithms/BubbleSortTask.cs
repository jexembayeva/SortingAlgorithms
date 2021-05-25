using System;

namespace SortingAlgorithms
{
    public class BubbleSortTask<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];

                    if (a.CompareTo(b) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
            }
        }
    }
}
