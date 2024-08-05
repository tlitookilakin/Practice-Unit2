namespace InfoCollector
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// welcome
			Console.WriteLine("Welcome to the Information Collector!");

			// collecting info
			Console.WriteLine("Please enter your name:");
			string? name = Console.ReadLine();

			int age;
			Console.WriteLine($"What is your age, {name}?");
			while (!int.TryParse(Console.ReadLine(), out age))
				Console.WriteLine("Not a valid number, please re-enter");

			Console.WriteLine($"What is your home town, {name}?");
			string? hometown = Console.ReadLine();

			// display information
			if (age >= 18)
				Console.WriteLine($"Thank you for your donation! $100000000 have been deducted from the {name} account in {hometown} bank.");
			else
				Console.WriteLine($"{name}, you shouldn't give out that kind of information!");

			Console.ReadKey();
		}
	}
}
