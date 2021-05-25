using DataStructures;
using System;

namespace SortingAlgorithms
{
    public class HeapSortTask<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var heap = new Heap<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }
    }
}
