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
			var dateTime = DateTime.Parse(dateTimeAsString);
			return dateTime.Year;
		}

		public int GetYearFromSplit(string dateTimeAsString)
		{
			var splitOnHyphen = dateTimeAsString.Split('-');

			return int.Parse(splitOnHyphen[0]);
		}
	}
}
