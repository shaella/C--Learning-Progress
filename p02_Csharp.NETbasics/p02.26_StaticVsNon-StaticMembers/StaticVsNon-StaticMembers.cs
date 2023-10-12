using System;
namespace StaticNonStatic
{
	public static class TemperatureConverter
	{
		public static double CelciusToFahrenheit(string temperaturCelcius)
		{
			double celcius = Double.Parse(temperaturCelcius);
			double fahrenheit = (celcius * 9 / 5) + 32;
			
			return fahrenheit;
		}

		public static double FahrenheitToCelcius(string temperatureFahrenheit)
		{
			double fahrenheit = Double.Parse(temperatureFahrenheit);
			double celcius = (fahrenheit - 32) * 5 / 9;
			
			return celcius;
		}
	}

	class Example
	{
		int x;
		static int y = 200;
		int z = 100;
		static void Add()
		{
			Example obj = new Example();
			Console.WriteLine("Sum of 100 and 200 is :" + (obj.z + y));
			Console.WriteLine("Sum of 100 and 200 is :" + (obj.z + Example.y));
		}

		void Mul()
		{
			Console.WriteLine($"Multiplication of 100 and 200 is :" + (this.z * Example.y));
			Console.WriteLine($"Multiplication of 100 and 200 is :" + (z * y));
		}

		static Example()
		{
			Console.WriteLine("Static Costructor is Called");
		}

		public Example()
		{
			Console.WriteLine("Non-static Constructor is Called");
		}

//		public Example(int x)
//		{
//			this.x = x;
//		}
		static void Main(string[] args)
		{
			Console.WriteLine("Main Method Execution Start");
			Example obj1 = new Example();
			Example obj2 = new Example();
			Console.WriteLine("Main Method Execution End");
			Console.WriteLine($"Static Variable Y = {Example.y}");
			Console.WriteLine($"Static Variable Y = {y}");
//			Example obj1 = new Example(50);
//			Example obj2 = new Example(100);
//			Console.WriteLine($"Object1 x = {obj1.x} and Object2 x = {obj2.x}");
			Example.Add();
			Add();
			Example obj = new Example();
			obj.Mul();
			Console.ReadLine();

			Console.WriteLine("Please select the convertor direction");
			Console.WriteLine("1. From Celcius to Fahrenheit.");
			Console.WriteLine("2. From Fahrenheit to Celcius.");
			Console.Write(":");

			string selection = Console.ReadLine();
			double F, C = 0;

			switch(selection)
			{
				case "1":
					Console.Write("Please enter the Celcius temperature: ");
					F = TemperatureConverter.CelciusToFahrenheit(Console.ReadLine());
					Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
					break;

				case "2":
					Console.Write("Please enter the Fahrenheit temperature: ");
					C = TemperatureConverter.FahrenheitToCelcius(Console.ReadLine());
					Console.WriteLine("Temperature in Celcius: {0:F2}", C);
					break;

				default:
					Console.WriteLine("Please select a convertor.");
					break;
			}

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
