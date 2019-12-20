using System;

namespace SimpleParser
{
	public class DateParser
	{
		public int GetYearFromDateTime(string dateTimeAsString)
		{
			int yearAsDateTime = DateTime.Parse(dateTimeAsString).Year;

			return yearAsDateTime;
		}

		public int GetYearFromSplit(string dateTimeAsString)
		{
			string[] splitOnHyphen = dateTimeAsString.Split('-');

			int yearAsSplit = int.Parse(splitOnHyphen[0]);

			return yearAsSplit;
		}

		public int GetYearFromSubstring(string dateTimeAsString)
		{
			int indexOfHyphen = dateTimeAsString.IndexOf('-');

			int yearAsSubstring =
				int.Parse(dateTimeAsString.Substring(0, indexOfHyphen));

			return yearAsSubstring;
		}

		public int GetYearFromSpan(ReadOnlySpan<char> dateTimeAsSpan)
		{
			int indexOfHyphen = dateTimeAsSpan.IndexOf('-');

			int yearAsSpan =
				int.Parse(dateTimeAsSpan.Slice(0, indexOfHyphen));

			return yearAsSpan;
		}

		public int GetYearFromSpanWithManualConversion(ReadOnlySpan<char> dateTimeAsSpan)
		{
			int indexOfHyphen = dateTimeAsSpan.IndexOf('-');

			var yearAsSpan = dateTimeAsSpan.Slice(0, indexOfHyphen);

			int temp = default;

			for (int i = 0; i < yearAsSpan.Length; i++)
			{
				temp = temp * 10 + (yearAsSpan[i] - '0');
			}

			return temp;
		}
	}
}
