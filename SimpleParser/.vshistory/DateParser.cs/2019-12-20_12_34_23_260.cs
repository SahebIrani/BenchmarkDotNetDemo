using System;

namespace SimpleParser
{
	/// <summary>
	/// 2019-12-13T16:33:06z
	/// </summary>
	public class DateParser
	{
		public int GetYearFromDateTime(string dateTimeAsString)
		{
			int dateTimeYear = DateTime.Parse(dateTimeAsString).Year;

			return dateTimeYear;
		}

		public int GetYearFromSplit(string dateTimeAsString)
		{
			string[] splitOnHyphen = dateTimeAsString.Split('-');

			int resultFromSplit = int.Parse(splitOnHyphen[0]);

			return resultFromSplit;
		}

		public int GetYearFromSubstring(string dateTimeAsString)
		{
			int indexOfHyphen = dateTimeAsString.IndexOf('-');

			int resultFromSubstring =
				int.Parse(dateTimeAsString.Substring(0, indexOfHyphen));

			return resultFromSubstring;
		}

		public int GetYearFromSpan(ReadOnlySpan<char> dateTimeAsSpan)
		{
			int indexOfHyphen = dateTimeAsSpan.IndexOf('-');

			int resultFromSpan =
				int.Parse(dateTimeAsSpan.Slice(0, indexOfHyphen));

			return resultFromSpan;
		}
	}
}
