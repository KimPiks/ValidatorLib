using BenchmarkDotNet.Running;

namespace Benchmarks
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<StringMethodsBenchmark>();
            BenchmarkRunner.Run<IntMethodsBenchmark>();
            BenchmarkRunner.Run<ObjectMethodsBenchmark>();
            BenchmarkRunner.Run<GuidMethodsBenchmark>();
        }
    }
}
