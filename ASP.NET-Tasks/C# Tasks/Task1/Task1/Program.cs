namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("You can enter any string : ");
			string input = Console.ReadLine();
			Console.WriteLine("You entered : "+input);
			/****************************************/
			double gpa = 3.67;
			Console.WriteLine("My GPA is : " + gpa);
			string name = "Rania";
			Console.WriteLine("My Name is : " + name);
			char grade = 'A';
			Console.WriteLine("My Grade is : " + grade);
			bool flag = true;
			Console.WriteLine("Flag value is : " + flag);
			int age = 20;
			Console.WriteLine("I'm " + age + " years old!");
			const double pi = Math.PI;
			Console.WriteLine("PI = " + pi);
			/****************************************/
			string[] cars = { "KIA", "Jaguar","Porsche" };
			for(int i = 0; i < cars.Length; i++)
			{
				Console.WriteLine("Car brand names number " + (i + 1) + " is " + cars[i]);
			}
			Console.WriteLine("Length of cars array is " + cars.Length);
			/****************************************/
			Console.WriteLine("Please Enter your First Name : ");
			string fName = Console.ReadLine();

			Console.WriteLine("Please Enter your Surname Name : ");
			string surname = Console.ReadLine();

			Console.WriteLine("Please Enter your Year of Birth : ");
			string yearOfBirth = Console.ReadLine();

			Console.WriteLine("Full Information : " + fName + " " + surname + " " + yearOfBirth);
            /****************************************/
            Console.WriteLine("Enter number of elements of array");
			int sizeOfDataArray = Convert.ToInt32(Console.ReadLine());
            int[] data = new int[sizeOfDataArray];
			for(int i = 0;i < data.Length;i++)
			{
                Console.WriteLine("Enter value of data["+i+"]");
				data[i] = Convert.ToInt32(Console.ReadLine());
            }
			/****************************************/
			int[] arr = { 1, 6, 9, 4, 2, 3, 4, 5, 6, 4 };
			long sum = 0;
			for (int i = 0; i < arr.Length; i++) 
			{
				sum += arr[i];
			}
			Console.WriteLine("Sum of all elements stored in the array is : " + sum);
        }
	}
}
