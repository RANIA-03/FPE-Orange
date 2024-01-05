namespace Task2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter first number");
			int n1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter first number");
			int n2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The Smaller is : " + (n1 < n2 ? n1 : n2));
			/****************************************/
			Console.WriteLine("Enter number to know the sign of the number");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The sign is " + (num > 0 ? "+" : (num < 0 ? "-" : "\"no sign to display\"")));
			/****************************************/
			int[] arr = new int[3];
			for(int i = 0; i < arr.Length; i++)
			{
                Console.WriteLine("Enter number to store in arr["+i+"]");
				arr[i] = Convert.ToInt32(Console.ReadLine());
            }
			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = 0; j < arr.Length - 1 - i; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
			Console.WriteLine("Sorted Array:");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			/****************************************/
			int[] myArr = new int[5];
			for (int i = 0; i < myArr.Length; i++)
			{
				Console.WriteLine("Enter number to store in myArr[" + i + "]:");
				myArr[i] = Convert.ToInt32(Console.ReadLine());
			}
			int maax = myArr[0];
			for (int i = 1; i < myArr.Length; i++)
			{
				if (maax < myArr[i])
					maax = myArr[i];
			}
			Console.WriteLine("Max number is : " + maax);
			/****************************************/
			Console.Write("Input kilometers per hour: ");
			double km = Convert.ToDouble(Console.ReadLine());
			double mile = km * 0.621371;
			Console.WriteLine(km + " km per hour is = " + mile + " mile per hour");
            /****************************************/
            Console.WriteLine("Enter houres");
			int houres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minutes");
			int minutes = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Total : " + (houres * 60 + minutes));
			/****************************************/
			Console.Write("Enter minutes: ");
			int totalMinutes = Convert.ToInt32(Console.ReadLine());
			int houresT = totalMinutes / 60;
			int reMinutes = totalMinutes % 60;
			Console.WriteLine("Total: {"+houres+"} Hours, {"+reMinutes+"} Minutes");
			/****************************************/
			string[] sentences ={
				"Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
				"Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
				"Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris.",
				"Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore.",
				"Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
			};
			int fixedLength = 30;
			Console.WriteLine("Printing sentences with fixed length ({"+fixedLength+"} characters):");
			foreach (string sentence in sentences)
			{
				string truncatedSentence = sentence.Length <= fixedLength
					? sentence.PadRight(fixedLength)
					: sentence.Substring(0, fixedLength);

				Console.WriteLine(truncatedSentence);
			}
            /****************************************/
            Console.WriteLine("Enter any string to reverse the odd words");
            string myStr = Console.ReadLine();
            Console.WriteLine("Original" + myStr);
			Console.WriteLine("Reversed" + reverseOdd(myStr));
        }
		static string reverseOdd(string input)
		{
			string[] words = input.Split(' ');
			for (int i = 0; i < words.Length; i++)
				if (words[i].Length % 2 != 0)
				{
					char[] charArray = words[i].ToCharArray();
					Array.Reverse(charArray);
					words[i] = new string(charArray);
				}
			return string.Join(" ", words);
		}
	}
}
