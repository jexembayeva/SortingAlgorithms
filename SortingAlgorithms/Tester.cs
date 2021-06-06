using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SortingAlgorithmsTest
{
    public class Tester
    {
        private readonly AlgorithmBase<int> _task;
        private readonly string _path;

        public Tester(AlgorithmBase<int> task, string path)
        {
            _task = task;
            _path = path;
        }

        public void RunTests()
        {
            var nr = 0;
            while (true)
            {
                var inFile = $"{_path}/test.{nr}.in";
                var outFile = $"{_path}/test.{nr}.out";

                if (!File.Exists(inFile) || !File.Exists(outFile))
                {
                    break;
                }

                var sw = new Stopwatch();
                sw.Start();
                var result = RunTest(inFile, outFile);
                sw.Stop();

                Console.WriteLine($"Test #{nr} - " + result + " " + sw.ElapsedMilliseconds + "ms");
                nr++;
            }
        }

        private bool RunTest(string inFile, string outFile)
        {
            try
            {
                var data = File.ReadAllLines(inFile);
                var expect = File.ReadAllText(outFile).Trim();
                _task.Items = Array.ConvertAll(data[1].Split(' ', ','), s => int.Parse(s));
                _task.Sort();
                var actual = string.Join(" ", _task.Items);

                return actual == expect;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
