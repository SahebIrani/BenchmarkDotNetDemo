using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace SimpleParser
{
	[MemoryDiagnoser, RankColumn, Orderer(SummaryOrderPolicy.FastestToSlowest)]
	public class ParserBenchmarks
	{

	}
}
