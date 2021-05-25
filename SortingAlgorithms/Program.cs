using SortingAlgorithmsTest;
using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############################## ShellSortTask ################################");
            var shellSortTask = new ShellSortTask<int>();

            Tester shellSortTester = new(shellSortTask);
            Console.WriteLine("----------------------------------Random----------------------------------");
            shellSortTester.RunTests(TestType.Random);
            Console.WriteLine("----------------------------------Digits----------------------------------");
            shellSortTester.RunTests(TestType.Digits);
            Console.WriteLine("----------------------------------Sorted----------------------------------");
            shellSortTester.RunTests(TestType.Sorted);
            Console.WriteLine("----------------------------------Reverse----------------------------------");
            shellSortTester.RunTests(TestType.Reversed);
            Console.WriteLine();

            Console.WriteLine("############################## HeapSort ################################");
            var heapSortTask = new HeapSortTask<int>();

            Tester heapSortTester = new(heapSortTask);
            Console.WriteLine("----------------------------------Random----------------------------------");
            heapSortTester.RunTests(TestType.Random);
            Console.WriteLine("----------------------------------Digits----------------------------------");
            heapSortTester.RunTests(TestType.Digits);
            Console.WriteLine("----------------------------------Sorted----------------------------------");
            heapSortTester.RunTests(TestType.Sorted);
            Console.WriteLine("----------------------------------Reverse----------------------------------");
            heapSortTester.RunTests(TestType.Reversed);
            Console.WriteLine();

            Console.WriteLine("############################ InsertionSort ###############################");
            var insertionSortTask = new InsertionSortTask<int>();

            Tester insertionSortTester = new(insertionSortTask);
            Console.WriteLine("----------------------------------Random----------------------------------");
            insertionSortTester.RunTests(TestType.Random);
            Console.WriteLine("----------------------------------Digits----------------------------------");
            insertionSortTester.RunTests(TestType.Digits);
            Console.WriteLine("----------------------------------Sorted----------------------------------");
            insertionSortTester.RunTests(TestType.Sorted);
            Console.WriteLine("----------------------------------Reverse----------------------------------");
            insertionSortTester.RunTests(TestType.Reversed);
            Console.WriteLine();

            Console.WriteLine("############################## BubbleSort ################################");
            var bubbleSortTask = new BubbleSortTask<int>();

            Tester bubbleSortTester = new(bubbleSortTask);
            Console.WriteLine("----------------------------------Random----------------------------------");
            bubbleSortTester.RunTests(TestType.Random);
            Console.WriteLine("----------------------------------Digits----------------------------------");
            bubbleSortTester.RunTests(TestType.Digits);
            Console.WriteLine("----------------------------------Sorted----------------------------------");
            bubbleSortTester.RunTests(TestType.Sorted);
            Console.WriteLine("----------------------------------Reverse----------------------------------");
            bubbleSortTester.RunTests(TestType.Reversed);
            Console.WriteLine();

        }
    }
}
