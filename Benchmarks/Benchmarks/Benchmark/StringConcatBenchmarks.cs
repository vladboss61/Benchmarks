namespace Benchmarks.Benchmark;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;

[MemoryDiagnoser] // Tracks memory allocation
[SimpleJob(RuntimeMoniker.Net80, baseline: true)]
[MarkdownExporter, HtmlExporter, CsvExporter]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[CategoriesColumn]
public class StringConcatBenchmarks
{
    [Params(10, 11)] // Run with 3 sizes
    public int Iterations;

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("String")]
    public string UsingString() => StringFunctions.ConcatWithString(Iterations);

    [Benchmark]
    [BenchmarkCategory("StringBuilder")]
    public string UsingStringBuilder() => StringFunctions.ConcatWithStringBuilder(Iterations);
}
