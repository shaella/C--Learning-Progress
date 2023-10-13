using System;
namespace Constructor
{
	public class ConstructorsDemo
	{
		public static int x;
		public int y;

		static ConstructorsDemo()
		{
			Console.WriteLine("Static Constructor is Called");
		}

		public ConstructorsDemo()
		{
			Console.WriteLine("Non-Static Constructor is Called");
		}

//		static void Main(string[] args)
//		{
//			Console.WriteLine("Main Method Body..");
//			Console.ReadKey();
//		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Main Method Started");
			
//			Console.WriteLine(ConstructorsDemo.x);

			ConstructorsDemo obj = new ConstructorsDemo();
			ConstructorsDemo obj1 = new ConstructorsDemo();
			ConstructorsDemo obj2 = new ConstructorsDemo();
			
			Console.WriteLine("Main Method Completed");
			Console.ReadKey();
		}
	}
}
