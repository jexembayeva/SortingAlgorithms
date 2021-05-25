using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortingAlgorithmsTest
{
    public class Tester
    {
        private AlgorithmBase<int> _task;
        public Tester(AlgorithmBase<int> task)
        {
            _task = task;
        }
        public void RunTests(TestType type)
        {
            int nr = 1;
            while (true)
            {
                if (nr % 1000000 == 0)
                {
                    break;
                }
                var items = GenerateItems(nr, type);

                _task.Items.Clear();
                _task.Items.AddRange(items);

                items.Sort();

                var sw = RunTask();

                Console.WriteLine($"Test #{nr} - " + RunTest(items) + " " + sw.ElapsedMilliseconds + "ms");

                nr *= 10;
            }
        }
        private static List<int> GenerateItems(int nr, TestType type)
        {
            var rnd = new Random();
            var items = new List<int>();
            for (int i = 0; i < nr; i++)
            {
                int minValue = 0;
                int maxValue = type == TestType.Digits ? 10 : 1000;
                items.Add(rnd.Next(minValue, maxValue));
            }

            switch (type)
            {
                case TestType.Random:
                    break;
                case TestType.Digits:
                    break;
                case TestType.Sorted:
                    items.Sort();
                    break;
                case TestType.Reversed:
                    items.Sort();
                    items.Reverse();
                    break;
            }
            return items;
        }

        private Stopwatch RunTask()
        {
            var sw = new Stopwatch();
            sw.Start();
            _task.Sort();
            sw.Stop();
            return sw;
        }
        private bool RunTest(List<int> items)
        {
            try
            {
                for (int i = 0; i < items.Count - 1; i++)
                {
                    if (items[i] != _task.Items[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }

    public enum TestType : long
    {
        Undefined = 0,
        Random,
        Digits,
        Sorted,
        Reversed
    }
}
