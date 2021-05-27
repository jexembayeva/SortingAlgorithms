using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SortingAlgorithmsTest
{
    public class Tester
    {
        private AlgorithmBase<int> _task;
        private string _path;

        public Tester(AlgorithmBase<int> task, string path)
        {
            _task = task;
            _path = path;
        }

        public void RunTests()
        {
            int nr = 0;
            while (true)
            {
                string inFile = $"{_path}\\test.{nr}.in";
                string outFile = $"{_path}\\test.{nr}.out";

                if (!File.Exists(inFile) || !File.Exists(outFile))
                {
                    break;
                }

                var sw = new Stopwatch();
                sw.Start();
                bool result = RunTest(inFile, outFile);
                sw.Stop();

                Console.WriteLine($"Test #{nr} - " + result + " " + sw.ElapsedMilliseconds + "ms");
                nr++;
            }
        }

        private bool RunTest(string inFile, string outFile)
        {
            try
            {
                string[] data = File.ReadAllLines(inFile);
                string expect = File.ReadAllText(outFile).Trim();
                _task.Items = Array.ConvertAll(data[1].Split(' ', ','), s => int.Parse(s));
                _task.Sort();
                string actual = string.Join(" ", _task.Items);

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
