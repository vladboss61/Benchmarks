using BenchmarkDotNet.Running;
using Benchmarks.Benchmark;

namespace Benchmarks;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<StringConcatBenchmarks>();
    }
}
