using System;
namespace ControlFlowDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 2;
			switch (x)
			{
				case 1:
					Console.WriteLine("Choice is 1");
				break;
				case 2:
				Console.WriteLine("Choice is 2");
				break;
				case 3:
				Console.WriteLine("Choice is 3");
				break;
				default:
				Console.WriteLine("Choice other than 1, 2, and 3");
				break;
			}

			string str = "C#2";
			Console.WriteLine("Switch Statement Started");
			switch (str)
			{
				case "C#":
				case "Java":
				case "C":
					Console.WriteLine("Its's a Programming Language");
					break;
				case "MYSQL":
				case "MySQL":
				case "Oracle":
					Console.WriteLine("It's a Database");
					break;
				case "MVC":
				case "WEB API":
					Console.WriteLine("It's a framework");
					break;
			}
			Console.WriteLine("Switch Statement Ended");


			string category;
			
			string topic = "Inheritance";

//			if ( topic.Equals("Introduction to C#") || topic.Equals("Variables") || topic.Equals("Data Types"))
//			{
//				category = "Basic";
//			}
//			else if (topic.Equals("Loops") || topic.Equals("If ELSE Statements") || topic.Equals("Jump Statements"))
//			{
//				category = "Control Flow";
//			}
//			else if (topic.Equals("Inheritance") || topic.Equals("Polymorphism") || topic.Equals("Abstraction") || topic.Equals("Encapsulation"))
//			{
//				category = "OOPS Concept";
//			}
//			else
//			{
//				category = "Invalid";
//			}
//			Console.Write($"{topic} Category is {category}");
//
			switch (topic)
			{
				case "Introduction to C#":
				case "Variables":
				case "Data Types":
					category = "Basic";
					break;
				case "Loops":
				case "If ELSE Statements":
				case "Jump Statements":
					category = "Control Flow";
					break;
				case "Inheritance":
				case "Polymorphism":
				case "Abstraction":
				case "Encapsulation":
					category = "OOPS Concept";
					break;
				default:
					category = "Invalid";
					break;
			}

			Console.WriteLine($"{topic} Category is {category}");


			Console.Write("Enter a Number Between 1 and 3:");
			int number = Convert.ToInt32(Console.ReadLine());
			switch (number)
			{
				case 1:
					Console.WriteLine("You Entered One");
					Console.Write("Enter Color Code (R/G/B): ");
					char color = Convert.ToChar(Console.ReadLine());
					switch (Char.ToUpper(color))
					{
						case 'R':
							Console.WriteLine("You have Selected Red Color");
							break;
						case 'G':
							Console.WriteLine("You have Selected Green Color");
							break;
						case 'B':
							Console.WriteLine("You have Selected Blue Color");
							break;
					}
					break;
				case 2:
					Console.WriteLine("You Entered Two");
					break;
				case 3:
					Console.WriteLine("You Entered Three");
					break;
				default:
					Console.WriteLine("Invalid Number");
					break;
			}

			Console.ReadKey();
		}
	}
}
