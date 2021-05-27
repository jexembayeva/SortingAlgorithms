using SortingAlgorithmsTest;
using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathRandom = @"C:\Users\Gaukhar\Downloads\sorting_tests-19350-c7b0c3\sorting-tests\0.random";
            var pathDigits = @"C:\Users\Gaukhar\Downloads\sorting_tests-19350-c7b0c3\sorting-tests\1.digits";
            var pathSorted = @"C:\Users\Gaukhar\Downloads\sorting_tests-19350-c7b0c3\sorting-tests\2.sorted";
            var pathRevers = @"C:\Users\Gaukhar\Downloads\sorting_tests-19350-c7b0c3\sorting-tests\3.revers";

            Console.WriteLine("############################## ShellSortTask ################################");
            var shellSortTask = new ShellSortTask<int>();

            Console.WriteLine("----------------------------------Random----------------------------------");
            Tester shellSortRandomTester = new(shellSortTask, pathRandom);
            shellSortRandomTester.RunTests();
            Console.WriteLine("----------------------------------Digits----------------------------------");
            Tester shellSortDigitsTester = new(shellSortTask, pathDigits);
            shellSortDigitsTester.RunTests();
            Console.WriteLine("----------------------------------Sorted----------------------------------");
            Tester shellSortSortedTester = new(shellSortTask, pathSorted);
            shellSortSortedTester.RunTests();
            Console.WriteLine("----------------------------------Reverse----------------------------------");
            Tester shellSortReverseTester = new(shellSortTask, pathRevers);
            shellSortReverseTester.RunTests();
            Console.WriteLine();

            Console.WriteLine("############################## HeapSort ################################");
            var heapSortTask = new HeapSortTask<int>();

            Console.WriteLine("----------------------------------Random----------------------------------");
            Tester heapSortRandomTester = new(heapSortTask, pathRandom);
            heapSortRandomTester.RunTests();
            Console.WriteLine("----------------------------------Digits----------------------------------");
            Tester heapSortDigitsTester = new(heapSortTask, pathDigits);
            heapSortDigitsTester.RunTests();
            Console.WriteLine("----------------------------------Sorted----------------------------------");
            Tester heapSortSortedTester = new(heapSortTask, pathSorted);
            heapSortSortedTester.RunTests();
            Console.WriteLine("----------------------------------Reverse----------------------------------");
            Tester heapSortReverseTester = new(heapSortTask, pathRevers);
            heapSortReverseTester.RunTests();
            Console.WriteLine();

            Console.WriteLine("############################ InsertionSort ###############################");
             var insertionSortTask = new InsertionSortTask<int>();

             Console.WriteLine("----------------------------------Random----------------------------------");
            Tester insertionSortRandomTester = new(insertionSortTask, pathRandom);
            insertionSortRandomTester.RunTests();
             Console.WriteLine("----------------------------------Digits----------------------------------");
            Tester insertionDigitsSortTester = new(insertionSortTask, pathRandom);
            insertionDigitsSortTester.RunTests();
             Console.WriteLine("----------------------------------Sorted----------------------------------");
            Tester insertionSortedSortTester = new(insertionSortTask, pathRandom);
            insertionSortedSortTester.RunTests();
             Console.WriteLine("----------------------------------Reverse----------------------------------");
            Tester insertionReverseSortTester = new(insertionSortTask, pathRandom);
            insertionReverseSortTester.RunTests();
             Console.WriteLine();

             Console.WriteLine("############################## BubbleSort ################################");
             var bubbleSortTask = new BubbleSortTask<int>();

             Console.WriteLine("----------------------------------Random----------------------------------");
            Tester bubbleSortRandomTester = new(insertionSortTask, pathRandom);
            bubbleSortRandomTester.RunTests();
            Console.WriteLine("----------------------------------Digits----------------------------------");
            Tester bubbleDigitsSortTester = new(insertionSortTask, pathRandom);
            bubbleDigitsSortTester.RunTests();
            Console.WriteLine("----------------------------------Sorted----------------------------------");
            Tester bubbleSortedSortTester = new(insertionSortTask, pathRandom);
            bubbleSortedSortTester.RunTests();
            Console.WriteLine("----------------------------------Reverse----------------------------------");
            Tester bubbleReverseSortTester = new(insertionSortTask, pathRandom);
            bubbleReverseSortTester.RunTests();
            Console.WriteLine();

        }
    }
}
