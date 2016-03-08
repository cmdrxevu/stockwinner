using System;
using System.Globalization;

namespace System
{
	public static class StringExtensions
	{
		public static decimal? ToDecimal(this string s)
		{
			var style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
			var culture = CultureInfo.CreateSpecificCulture("en-US");
			
			decimal value;
			if(string.IsNullOrEmpty(s)
				|| !decimal.TryParse(s, style, culture, out value))
			{
				return new decimal?();
			}
			
			return value;
		}
		
		public static DateTime? ToDateTime(this string s)
		{
			var culture = CultureInfo.CreateSpecificCulture("en-US");
			
			DateTime value;
			if(string.IsNullOrEmpty(s)
				|| (!DateTime.TryParseExact(s, "MM/dd/yyyy", culture, DateTimeStyles.None, out value)
				&& !DateTime.TryParseExact(s, "M/d/yyyy", culture, DateTimeStyles.None, out value)))
			{
				return new DateTime?();
			}
			
			return value;
		}
		
		public static DateTime? ToTime(this string s)
		{
			var culture = CultureInfo.CreateSpecificCulture("en-US");
			
			DateTime value;
			if(string.IsNullOrEmpty(s)
				|| !DateTime.TryParseExact(s.ToUpper(), "h:mmtt", culture, DateTimeStyles.None, out value))
			{
				return new DateTime?();
			}
			
			return value;
		}
	}
}