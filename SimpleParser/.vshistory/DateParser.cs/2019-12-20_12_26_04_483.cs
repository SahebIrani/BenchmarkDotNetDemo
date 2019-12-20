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
			DateTime dateTime = DateTime.Parse(dateTimeAsString);
			return dateTime.Year;
		}

		public int GetYearFromSplit(string dateTimeAsString)
		{
			string[] splitOnHyphen = dateTimeAsString.Split('-');
			int result = int.Parse(splitOnHyphen[0]);
			return result;
		}

		public int GetYearFromSubstring(string dateTimeAsString)
		{
			int indexOfHyphen = dateTimeAsString.IndexOf('-');
			return int.Parse(dateTimeAsString.Substring(0, indexOfHyphen));
		}

		public int GetYearFromSpan(string dateTimeAsString)
		{

		}
	}
}
