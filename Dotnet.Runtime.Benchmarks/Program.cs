using BenchmarkDotNet.Running;

namespace Dotnet.Runtime.Benchmarks
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<XmlConfigurationBenchmarks>();
        }
    }
}