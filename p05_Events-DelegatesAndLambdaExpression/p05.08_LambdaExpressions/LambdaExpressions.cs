using System;
namespace LambdaExpressionDemo
{
	public class LambdaExpression
	{
		public delegate string GreetingsDelegate(string name);
		static void Main(string[] args)
		{
//			GreetingsDelegate obj = new GreetingsDelegate(LambdaExpression.Greetings);
//			GreetingsDelegate obj = delegate (string name)
			GreetingsDelegate obj = (name) =>
			{
				return "Hello @" + name + " welcome to Dotnet Tutorials";
			};
			string GreetingsMessage = obj.Invoke("Pranaya");
			Console.WriteLine(GreetingsMessage);
			Console.ReadKey();
		}

//		public static string Greetings(string name)
//		{
//			return "Hello @" + name + " welcome to Dotnet Tutorials";
//		}
	}
}
