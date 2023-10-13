using System;
namespace AbstractClassesAndMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			Example.Method1();

			// Example e = new Example(); //Error

			// e.Method2(); //Not possible

			AbsParent.StaticMethod();

			AbsChild absChild = new AbsChild();

			absChild.NonStaticMethod();

			absChild.AbstractMethod();

			Console.ReadKey();
		}
	}

	public abstract class AbsParent
	{
		public static void StaticMethod()
		{
			Console.WriteLine("Static Method");
		}

		public void NonStaticMethod()
		{
			Console.WriteLine("Non-Static Method");
		}

		public abstract void AbstractMethod();
	}

	public class AbsChild : AbsParent
	{
		public override void AbstractMethod()
		{
			Console.WriteLine("AbstractMethod Implemented in child class");
		}
	}

	public abstract class Example
	{
		public static void Method1()
		{
			Console.WriteLine("Example Method1 method");
		}
		public void Method2()
		{
			Console.WriteLine("Example Method2 method");
		}
	}
}

