using System;
namespace ControlFlow
{
	class Program
	{
		static void Main(string[] args)
		{
			int number;
			Console.WriteLine("Enter a Number: ");
			number = Convert.ToInt32(Console.ReadLine());
			if (number > 10)
			{
				Console.WriteLine($"{number} is greater than 10 ");
				Console.WriteLine("End of if block");
			}
			Console.WriteLine("End of Main Method");

			int number2;
                        Console.WriteLine("Enter a Number: ");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        if (number2 > 10)
                                Console.WriteLine($"{number2} is greater than 10 ");
                        Console.WriteLine("End of Main Method");

			Console.WriteLine("Enter a Number: ");
			int number3 = Convert.ToInt32(Console.ReadLine());
			if (number3 % 2 == 0)
			{
				Console.WriteLine($"{number3} is an Even Number");
			}
			else
			{
				Console.WriteLine($"{number3} is an Odd Number");
			}

			int number4 = 10;
			if (number4 == 10)
			{
				Console.WriteLine("Hi");
				Console.WriteLine("Hello");
			}
			else
				Console.WriteLine("Bye");
			
			int a = 15, b = 25, c = 10;
			int LargestNumber = 0;
			if (a > b)
			{
				Console.WriteLine($"Outer IF Block");
				if (a > c)
				{
					Console.WriteLine($"Outer IF - Inner IF Block");
					LargestNumber = a;
				}
				else
				{
					Console.WriteLine($"Outer IF - Inner ELSE Block");
					LargestNumber = c;
				}
			}
			else
			{
				Console.WriteLine($"Outer ELSE Block");
				if (b > c)
				{
					Console.WriteLine($"Outer ELSE - Inner IF Block");
					LargestNumber = b;
				}
				else
				{
					Console.WriteLine($"Outer ELSE - Inner ELSE Block");
					LargestNumber = c;
				}
			}
			Console.WriteLine($"The Largest Number is :{LargestNumber}");

			Console.WriteLine($"a={a}, b={b}, c={c}");
			LargestNumber = (a > b) ? ((a > c)?(a):(c)) : ((b > c) ?(b):(c));
			Console.WriteLine($"The Largest Number is :{LargestNumber}");

			int i = 20;
			if (i == 10)
			{
				Console.WriteLine("i is 10");
			}
			else if (i == 15)
			{
				Console.WriteLine("i is 15");
			}
			else if (i == 20)
                        {
                                Console.WriteLine("i is 20");
                        }
			else
			{
                                Console.WriteLine("i is not present");
                        }

			Console.ReadKey();
		}
	}
}
