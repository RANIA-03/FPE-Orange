namespace Task7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			StreamWriter sw = new StreamWriter("C:\\Users\\rania\\OneDrive\\Desktop\\rania.txt");
			sw.WriteLine("Rania Shelbayeh\n" +
				"Computer Information Systems\n" +
				"I'm 20 years old\n" +
				"no description\n" +
				"Asp.Net Developer.");
			sw.Close();
			StreamReader sr = new StreamReader("C:\\Users\\rania\\OneDrive\\Desktop\\rania.txt");
			int totalCharacters = 0;
			int totalWords = 0;
			string line = sr.ReadLine();
			while(line != null)
			{
                Console.WriteLine(line);
				totalCharacters += line.Replace(" ", "").Length;
				totalWords += line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
				line = sr.ReadLine();
            }
			sr.Close();
			Console.WriteLine("Total #characters: " + totalCharacters);
			Console.WriteLine("Total #words: " + totalWords);

		}
	}
}
