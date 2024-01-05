namespace Task6
{
	internal class Program
	{
		class Vehicle
		{
			public string Make { get; set; }
			public int Year { get; set; }
			public string Type { get; set; }
			public decimal Price { get; set; }
			public Vehicle(string make, int year, string type, decimal price)
			{
				Make = make;
				Year = year;
				Type = type;
				Price = price;
			}
			public virtual string GetDetails()
			{
				return $"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price:C}";
			}
		}
		class Car : Vehicle
		{
			public string Model { get; set; }
			public string PalletNo { get; set; }
			public string Color { get; set; }
			public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
				: base(make, year, type, price)
			{
				Model = model;
				PalletNo = palletNo;
				Color = color;
			}
			public void StartEngine()
			{
				Console.WriteLine("Engine started!");
			}
			public void StopEngine()
			{
				Console.WriteLine("Engine stopped!");
			}
			public override string GetDetails()
			{
				return $"{base.GetDetails()}, Model: {Model}, Pallet No: {PalletNo}, Color: {Color}";
			}
		}
		static void Main(string[] args)
		{
			Car kiaOptima = new Car("Kia", 2023, "Sedan", 28000.75m, "Optima", "789012", "Silver");
			kiaOptima.StartEngine();
			kiaOptima.StopEngine();
			Console.WriteLine("My Car Details for Kia Optima:");
			Console.WriteLine(kiaOptima.GetDetails());
		}
	}
}
