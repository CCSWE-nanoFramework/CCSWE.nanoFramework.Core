using nanoFramework.Benchmark;
using nanoFramework.Benchmark.Attributes;

namespace CCSWE.nanoFramework.Core.Benchmarks
{
    [IterationCount(250)]
    public class EnsureBenchmarks: BenchmarkBase
    {
        private const string StringValue = nameof(EnsureBenchmarks);

        [Benchmark]
        public void IsInRange_Double()
        {
            Ensure.IsInRange(nameof(IsInRange_Double), 0d, 0, 1);
        }

        [Benchmark]
        public void IsInRange_Expression()
        {
            var value = 0d;
            var min = 0d;
            var max = 1d;

            Ensure.IsInRange(nameof(IsInRange_Expression), value >= min && value <= max);
        }

        [Benchmark]
        public void IsInRange_Float()
        {
            Ensure.IsInRange(nameof(IsInRange_Float), 0f, 0, 1);
        }

        [Benchmark]
        public void IsInRange_Int()
        {
            Ensure.IsInRange(nameof(IsInRange_Int), 0, 0, 1);
        }

        [Benchmark]
        public void IsInRange_Long()
        {
            Ensure.IsInRange(nameof(IsInRange_Long), 0L, 0, 1);
        }

        [Benchmark]
        public void IsNotNull()
        {
            Ensure.IsNotNull(nameof(IsNotNull), StringValue);
        }

        [Benchmark]
        public void IsNotNullOrEmpty()
        {
            Ensure.IsNotNullOrEmpty(nameof(IsNotNullOrEmpty), StringValue);
        }

        [Benchmark]
        public void IsValid()
        {
            var value = 0d;
            var min = 0d;
            var max = 1d;

            Ensure.IsValid(nameof(IsValid), value >= min && value <= max);
        }
    }
}
