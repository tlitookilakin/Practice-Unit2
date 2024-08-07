namespace MethodLecture
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyMethod();
			DisplayGreeting("Wren");
			Console.WriteLine(Adder(2, 3));
			Console.WriteLine(AreaOfTriangle(13.0, 8.0));
            Console.WriteLine(GetSalary(Console.ReadLine()));


            Console.ReadKey();
		}

		static void MyMethod()
		{
            Console.WriteLine("I just ran!");
        }

		static void DisplayGreeting(string name)
		{
            Console.WriteLine($"Hello {name}!");
        }

		static int Adder(int x, int y)
		{
			return x + y;
		}

		static double AreaOfTriangle(double height, double length)
		{
			return (height * length) / 2.0;
		}

		static double GetSalary(string job)
		{
			switch (job)
			{
				case "Janitor":
					return 50_000.0;
				case "Developer":
					return 70_000.0;
				case "CEO":
					return 100_000.0;
				default:
					return 0.0;
			}
		}
	}
}
