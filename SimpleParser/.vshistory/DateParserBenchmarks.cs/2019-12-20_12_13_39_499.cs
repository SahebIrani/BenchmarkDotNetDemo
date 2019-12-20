using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace SimpleParser
{
	[MemoryDiagnoser, RankColumn, Orderer(SummaryOrderPolicy.)]
	public class ParserBenchmarks
	{
		private const string DateTime = "2019-12-13T16:33:06Z";
		private static readonly DateParser Parser = new DateParser();

		[Benchmark]
		public void GetYearFromDateTime()
		{
			Parser.GetYearFromDateTime(DateTime);
		}
	}
}
