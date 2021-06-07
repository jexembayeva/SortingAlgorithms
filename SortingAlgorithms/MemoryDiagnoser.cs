using BenchmarkDotNet.Attributes;
using SortingAlgorithms;
using System.IO;
using System;

namespace SortingAlgorithmsTest
{
    [MemoryDiagnoser]
    public class AlgorithmRandomBenchmark
    {
        private readonly int[] _data;

        public AlgorithmRandomBenchmark()
        {
            var pathRandom = @"C:\Users\g.jexembayeva\source\algorithms\sorting-tests\0.random";
            var nr = 4;
            var inFile = $"{pathRandom}\\test.{nr}.in";
            var outFile = $"{pathRandom}\\test.{nr}.out";

            var data = File.ReadAllLines(inFile);
            _data = Array.ConvertAll(data[1].Split(' ', ','), s => int.Parse(s));
        }

        [Benchmark]
        public void HsDo()
        {
            var hsAlg = new HeapSortAlgorithm();
            hsAlg.Sort(_data);
        }

        [Benchmark]
        public void SsDo()
        {
            var ssAlg = new ShellSortAlgorithm();
            ssAlg.Sort(_data);
        }


        [Benchmark]
        public void IsDo()
        {
            var isAlg = new InsertionSortAlgorithm();
            isAlg.Sort(_data);
        }

        [Benchmark]
        public void BsDo()
        {
            var bsAlg = new BubbleSortAlgorithm();
            bsAlg.Sort(_data);
        }
    }

    [MemoryDiagnoser]
    public class AlgorithmDigitsBenchmark
    {
        private readonly int[] _data;

        public AlgorithmDigitsBenchmark()
        {
            var pathRandom = @"C:\Users\g.jexembayeva\source\algorithms\sorting-tests\1.digits";
            var nr = 4;
            var inFile = $"{pathRandom}\\test.{nr}.in";
            var outFile = $"{pathRandom}\\test.{nr}.out";

            var data = File.ReadAllLines(inFile);
            _data = Array.ConvertAll(data[1].Split(' ', ','), s => int.Parse(s));
        }

        [Benchmark]
        public void HsDo()
        {
            var hsAlg = new HeapSortAlgorithm();
            hsAlg.Sort(_data);
        }

        [Benchmark]
        public void SsDo()
        {
            var ssAlg = new ShellSortAlgorithm();
            ssAlg.Sort(_data);
        }


        [Benchmark]
        public void IsDo()
        {
            var isAlg = new InsertionSortAlgorithm();
            isAlg.Sort(_data);
        }

        [Benchmark]
        public void BsDo()
        {
            var bsAlg = new BubbleSortAlgorithm();
            bsAlg.Sort(_data);
        }
    }

    [MemoryDiagnoser]
    public class AlgorithmSortedBenchmark
    {
        private readonly int[] _data;

        public AlgorithmSortedBenchmark()
        {
            var pathRandom = @"C:\Users\g.jexembayeva\source\algorithms\sorting-tests\2.sorted";
            var nr = 4;
            var inFile = $"{pathRandom}\\test.{nr}.in";
            var outFile = $"{pathRandom}\\test.{nr}.out";

            var data = File.ReadAllLines(inFile);
            _data = Array.ConvertAll(data[1].Split(' ', ','), s => int.Parse(s));
        }

        [Benchmark]
        public void HsDo()
        {
            var hsAlg = new HeapSortAlgorithm();
            hsAlg.Sort(_data);
        }

        [Benchmark]
        public void SsDo()
        {
            var ssAlg = new ShellSortAlgorithm();
            ssAlg.Sort(_data);
        }


        [Benchmark]
        public void IsDo()
        {
            var isAlg = new InsertionSortAlgorithm();
            isAlg.Sort(_data);
        }

        [Benchmark]
        public void BsDo()
        {
            var bsAlg = new BubbleSortAlgorithm();
            bsAlg.Sort(_data);
        }
    }

    [MemoryDiagnoser]
    public class AlgorithmReversBenchmark
    {
        private readonly int[] _data;

        public AlgorithmReversBenchmark()
        {
            var pathRandom = @"C:\Users\g.jexembayeva\source\algorithms\sorting-tests\3.revers";
            var nr = 4;
            var inFile = $"{pathRandom}\\test.{nr}.in";
            var outFile = $"{pathRandom}\\test.{nr}.out";

            var data = File.ReadAllLines(inFile);
            _data = Array.ConvertAll(data[1].Split(' ', ','), s => int.Parse(s));
        }

        [Benchmark]
        public void HsDo()
        {
            var hsAlg = new HeapSortAlgorithm();
            hsAlg.Sort(_data);
        }

        [Benchmark]
        public void SsDo()
        {
            var ssAlg = new ShellSortAlgorithm();
            ssAlg.Sort(_data);
        }


        [Benchmark]
        public void IsDo()
        {
            var isAlg = new InsertionSortAlgorithm();
            isAlg.Sort(_data);
        }

        [Benchmark]
        public void BsDo()
        {
            var bsAlg = new BubbleSortAlgorithm();
            bsAlg.Sort(_data);
        }
    }
}

