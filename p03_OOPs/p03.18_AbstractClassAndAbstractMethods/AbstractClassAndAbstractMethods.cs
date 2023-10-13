using System;
namespace AbstractClassesAndMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			AbsChild absChild = new AbsChild();
			absChild.Add(10, 5);
			absChild.Sub(10, 5);
			absChild.Mul(10, 5);
			absChild.Div(10, 2);

			AbsParent absParent = absChild;

			absParent.Add(10, 5);
                        absParent.Sub(10, 5);
                        absParent.Mul(10, 5);
                        absParent.Div(10, 2);

			Console.ReadKey();
		}
	}

public abstract class AbsParent
{
	public void Add(int x, int y)
	{
		Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
	}
	public void Sub(int x, int y)
	{
		Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
	}
	public abstract void Mul(int x, int y);
	public abstract void Div(int x, int y);
}

public class AbsChild : AbsParent
{
	public override void Mul(int x, int y)
	{
		Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
	}
	public override void Div(int x, int y)
	{
		Console.WriteLine($"Division of {x} and {y} is : {x / y}");
	}
	public void Mod(int x, int y)
	{
		Console.WriteLine($"Modulos of {x} and {y} is : {x % y}");
	}
}
}
