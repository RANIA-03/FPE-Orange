namespace ProblemSolvingTask3
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
		static int Add(int n1, int n2)
		{
			return n1 + n2;
		}
		static string removeLeadingTrailing(string str)
		{
			int start = 0, end = str.Length - 1;
			while (start < str.Length && str[start] == '0')
			{
				start++;
			}
			while (end >= 0 && str[end] == '0')
			{
				end--;
			}
			int indx = str.IndexOf('.');
			if (indx != -1 && end > indx)
			{
				while (end >= 0 && str[end] == '0')
				{
					end--;
				}
			}
			return str.Substring(start, end - start + 1);
		}
		static int secondLargest(int[] arr)
		{
			int ma = arr[0], secMa = arr[0];
			foreach (int i in arr)
			{
				if (i > ma)
				{
					secMa = ma;
					ma = i;
				}
				else if (i > secMa && i != ma)
				{
					secMa = i;
				}
			}
			return secMa;
		}
		static bool isRepdigit(int n) 
		{
			int i = n % 10;
			n /= 10;
			while (n > 0)
			{
				int r = n % 10;
				if(r != i)
				{
					return false;
				}
				n /= 10;
			}
			return true;
		}
		static string reverseWords(string str)
		{
			string[] s = str.Split(' ');
			for (int i = 0; i < s.Length / 2; i++)
			{
				string temp = s[i];
				s[i] = s[s.Length - i - 1];
				s[s.Length - i - 1] = temp;
			}
			string result = string.Join(" ", s);
			return result;
		}
		static string insertWhitespace(string s)
		{
			string str = "";
			for (int i = 0; i < s.Length; i++)
			{
				if (i != s.Length - 1 && char.IsLower(s[i]) && char.IsUpper(s[i + 1]))
				{
					str += " ";
				}
				str += s[i];
			}
			return str;
		}
		static int countTrue(bool[] arr)
		{
			int c = 0;
			foreach(bool b in arr)
			{
				if (b)
					c++;
			}
			return c;
		}
		static string capToFront(string s)
		{
			string capL = "", lowl = "";
			for(int i = 0;i < s.Length; i++)
			{
				if (char.IsLower(s[i]))
				{
					lowl += s[i];
				}
				else
				{
					capL += s[i];
				}
			}
			return capL + lowl;
		}
		static bool matchLastItem(string[] arr)
		{
			string s = arr[arr.Length-1],str = "";
			foreach(string i in arr)
			{
				str += i;
			}
			if(s == str)
				return true;
			return false;
		}
		static int findNaN(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (double.IsNaN(arr[i]))
				{
					return i;
				}
			}
			return -1;
		}
		static T[] removeDups<T>(T[] inputArray)
		{
			HashSet<T> uniqueItems = new HashSet<T>();
			List<T> result = new List<T>();

			foreach (var item in inputArray)
			{
				if (uniqueItems.Add(item))  
				{
					result.Add(item);
				}
			}
			return result.ToArray();
		}
		static string convertTime(string time)
		{
			DateTime parsedTime = DateTime.ParseExact(time, "hh:mm:sstt", null);
			return parsedTime.ToString("HH:mm:ss");
		}
		static string removeLastVowel(string sentence)
		{
			string[] words = sentence.Split(' ');
			for (int i = 0; i < words.Length; i++)
			{
				char[] characters = words[i].ToCharArray();
				for (int j = characters.Length - 1; j >= 0; j--)
				{
					if ("aeiouAEIOU".Contains(characters[j]))
					{
						characters[j] = '\0';
						break;
					}
				}
				words[i] = new string(characters).Replace("\0", "");
			}
			return string.Join(" ", words);
		}
		static long sumOfCubes(int[] arr)
		{
			long sum = 0;
			foreach(int item in arr) { 
				sum += (long)Math.Pow(item,3);
			}
			return sum;
		}
	}
}
