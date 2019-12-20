using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace SimpleParser
{
	[MemoryDiagnoser, RankColumn, Orderer(SummaryOrderPolicy.FastestToSlowest)]
	public class DateParserBenchmarks
	{
		private const string DateTime = "2019-12-13T16:33:06Z";
		private static readonly DateParser Parser = new DateParser();


		[Benchmark(Baseline = true)]
		public void GetYearFromDateTime()
			=> Parser.GetYearFromDateTime(DateTime);


		[Benchmark]
		public void GetYearFromSplit()
		{
			Parser.GetYearFromSplit(DateTime);
		}
	}
}
