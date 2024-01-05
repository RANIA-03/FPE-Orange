using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	internal class myDate
	{
		public static void convertDate(string dateString)
		{
			char[] specialChar = { '/', '-' };
			string[] date = dateString.Split(specialChar);
			if (date.Length == 3 && int.TryParse(date[0], out int month) &&	int.TryParse(date[1], out int day) &&	int.TryParse(date[2], out int year))
			{
				DateTime result1 = new DateTime(year, month, day);
				Console.WriteLine($"Converted Date: {result1:yyyy-MM-dd}");
			}
			else
			{
				DateTime result2;
				if (DateTime.TryParseExact(dateString, "d-M-yyyy", null, System.Globalization.DateTimeStyles.None, out result2))
					Console.WriteLine($"Converted Date: {result2:yyyy-MM-dd}");
			}
		}
	}
}
