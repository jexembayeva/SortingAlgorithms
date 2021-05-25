using SortingAlgorithms;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlgorithmsTest
{
    public class BubbleSortTest
    {
        [Fact]
        public void Test1()
        {
            var rnd = new Random();
            var items = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(rnd.Next(0, 100));
            }
            var bubble = new BubbleSortTask<int>();
            bubble.Items.AddRange(items);

            bubble.Sort();
        }
    }
}
