namespace SortingAlgorithmsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkDotNet.Running.BenchmarkRunner.Run<AlgorithmRandomBenchmark>();
            BenchmarkDotNet.Running.BenchmarkRunner.Run<AlgorithmDigitsBenchmark>();
            BenchmarkDotNet.Running.BenchmarkRunner.Run<AlgorithmSortedBenchmark>();
            BenchmarkDotNet.Running.BenchmarkRunner.Run<AlgorithmReversBenchmark>();
        }
    }

}
