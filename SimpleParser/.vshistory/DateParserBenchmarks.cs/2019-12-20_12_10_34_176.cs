using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace SimpleParser
{
	[MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest), RankColumn]
	public class ParserBenchmarks
	{

	}
}
