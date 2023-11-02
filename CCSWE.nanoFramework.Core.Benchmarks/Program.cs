using System;
using System.Diagnostics;
using System.Threading;
using nanoFramework.Benchmark;

namespace CCSWE.nanoFramework.Core.Benchmarks
{
    public class Program
    {
        public static void Main()
        {
#if DEBUG
            Console.WriteLine("Benchmarks should be run in a release build.");
            Debugger.Break();
            return;
#endif

            BenchmarkRunner.RunClass(typeof(EnsureBenchmarks));
        }
    }
}
