namespace ProblemSolvingTask2
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
		static int getDays(DateTime date1 , DateTime date2){
			TimeSpan timeDiff = date2 - date1;
			int days = timeDiff.Days;
			return days;
		}
		static string[] numInStr(string[] arr)
		{
			var myArr = arr.Where(s => s.Any(char.IsDigit)).ToArray();
			return myArr;
		}
		static string reverseOdd(string s)
		{
			if (s.Length % 2 != 0)
			{
				char[] charArray = s.ToCharArray();
				for (int i = 0; i < s.Length / 2; i++)
				{
					char temp = charArray[i];
					charArray[i] = charArray[s.Length - i - 1];
					charArray[s.Length - i - 1] = temp;
				}
				return new string(charArray);
			}
			return s;
		}
		static bool isPandigital(long s)
		{
			bool[] digits = new bool[10];
			while (s > 0)
			{
				int r = (int)s % 10;
				digits[r] = true;
				s /= 10;
			}
			foreach(bool b in digits)
			{
				if (!b)
					return false;
			}
			return true;
		}
	}
}
