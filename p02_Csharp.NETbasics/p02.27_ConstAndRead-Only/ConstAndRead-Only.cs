using System;
namespace ConstDemo //, TypesOfVariables
{
	internal class Program
	{
		static int w = 100;
		int y;
		readonly int z;
		readonly int x;
		readonly int number = 5;
		readonly int numberc = 5;
		readonly int numbers;
		public const float PI = 3.14f;
		int Age = 10;
		static string Message = "Good Morning";

		public Program(int a, int b)
		{
			y = a;
			z = b;
		}

//		public Program(int num)
//		{
//			numberc = 20;
//			numbers = num;
//		}

		static void Main(string[] args)
		{
			Program obj = new Program(10,10);
			Console.WriteLine($"x value: {obj.x}");
			Console.WriteLine($"PI value: {PI}");
			
			Console.WriteLine(Program.PI);
			Console.WriteLine(PI);
			const int Number = 10;
			Console.WriteLine(Number);
			Program obj1 = new Program(300, 45);
			Program obj4 = new Program(400, 55);
			Console.WriteLine($"{obj1.x}");
			Console.WriteLine(obj1.number);
			Console.WriteLine(obj1.numberc);
//			Program obj2 = new Program(100);
//			Console.WriteLine(obj2.numbers);
//			Program obj3 = new Program(200);
//			Console.WriteLine(obj3.numbers);
			Console.WriteLine($"obj1 y value: {obj1.y} and Readonly z value: {obj1.z}");
			Console.WriteLine($"obj4 y value: {obj4.y} and Readonly z value: {obj4.z}");
			Console.ReadLine();
		}
	}
}

