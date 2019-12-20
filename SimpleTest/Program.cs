using BenchmarkDotNet.Running;

using SimpleParser;

namespace SimpleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<DateParserBenchmarks>();
		}
	}
}
