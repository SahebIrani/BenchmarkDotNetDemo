using System;

namespace SimpleParser
{
	/// <summary>
	/// 2019-12-13T16:33:062
	/// </summary>
	public class DateParser
	{
		public int GetYearFromDateTime(string dateTimeAsString)
		{
			var dateTime = DateTime.Parse(dateTimeAsString);
			return dateTime.Year;
		}
	}
}
