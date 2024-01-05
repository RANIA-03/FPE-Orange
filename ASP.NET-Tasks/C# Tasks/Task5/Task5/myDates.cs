using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	internal class myDates
	{
		public static void diffBetweenTwoDates(DateTime date1, DateTime date2)
		{
			TimeSpan difference = date2 - date1;
			int years = difference.Days / 365;
			int months = (difference.Days % 365) / 30;
			int days = difference.Days % 30;
			Console.WriteLine($"Difference: {years} years, {months} months, {days} days.");
		}
	}
}
