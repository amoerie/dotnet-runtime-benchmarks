using System.IO;
using BenchmarkDotNet.Attributes;
using Dotnet.Runtime.Benchmarks.After;

namespace Dotnet.Runtime.Benchmarks
{
    [MemoryDiagnoser]
    public class XmlConfigurationBenchmarks
    {
        [Params("simple.xml", "deep.xml", "names.xml", "repeated.xml")]
        public string TestFile { get; set; }
        
        [Benchmark(Baseline = true)]
        public void Before()
        {
            var provider = new Microsoft.Extensions.Configuration.Xml.XmlConfigurationProvider(new Microsoft.Extensions.Configuration.Xml.XmlConfigurationSource());
            
            using var fileStream = File.OpenRead(TestFile);

            provider.Load(fileStream);
        }

        [Benchmark]
        public void After()
        {
            var provider = new XmlConfigurationProvider(new XmlConfigurationSource());
            
            using var fileStream = File.OpenRead(TestFile);

            provider.Load(fileStream);
        }
    }
}