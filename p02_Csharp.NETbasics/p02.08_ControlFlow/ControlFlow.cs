using System;
namespace ControlFlow
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executing Statement1");
			Console.WriteLine("Executing Statement2");
			Console.WriteLine("Executing Statement3");
			Console.WriteLine("Executing Statement4");
			Console.WriteLine("Executing Statement5");

			if(10 > 5)
			{
				Console.WriteLine("Executing Statement1");
				Console.WriteLine("Executing Statement2");
			}
			else
			{
				Console.WriteLine("Executing Statement3");
				Console.WriteLine("Executing Statement4");
			}
			Console.WriteLine("Executing Statement5");
			
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Welcome to C#.NET");
			}
			Console.WriteLine("Some Other Statement");

			Console.WriteLine("Executing Statement1");
			goto statement4;
			Console.WriteLine("Executing Statement2");
			Console.WriteLine("Executing Statement3");
statement4:
			Console.WriteLine("Executing Statement4");
			Console.WriteLine("Executing Statement5");
			Console.ReadKey();
		}
	}
}
