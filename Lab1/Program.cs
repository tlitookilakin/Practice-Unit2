namespace Lab1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the room calculator!");

			// get information

			Console.WriteLine("Please enter the width of the room:");
			var width = double.Parse(Console.ReadLine());

			Console.WriteLine("Please enter the depth of the room:");
			var depth = double.Parse(Console.ReadLine());

			Console.WriteLine("Please enter the height of the room:");
			var height = double.Parse(Console.ReadLine());

			// calculations

			// 2d
			double area = width * depth;
			double perimeter = width * 2.0 + depth * 2.0;

			// 3d
			double volume = height * area;
			double surface = perimeter * height + area * 2.0;

			// size
			var size = area switch
			{
				>= 650 => "large",
				> 250 => "medium",
				> 0 => "small",
				_ => "non-euclidean"
			};

			// display information

			Console.WriteLine($"\nThis is a {size} room,");
			Console.WriteLine($"with a floor area of {area} and perimeter of {perimeter},");
			Console.WriteLine($"as well as a volume of {volume} and surface area of {surface}");

			// goodbye

			Console.WriteLine("\nThank you for using the Room Calculator! Have a nice day!");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}
