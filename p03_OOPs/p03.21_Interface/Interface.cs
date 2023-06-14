using System;
namespace AbstractClassMethods
{
	class Program
	{
		static void Main()
		{
			ITestInterface1 obj = new ImplementationClass();
			obj.Add(10, 20);
			
			ImplementationClass1 obj1 = new ImplementationClass1();
			obj1.Add(10,20);
			ImplementationClass2 obj2 = new ImplementationClass2();
			obj2.Add(10,20);
			obj2.Sub(100,20);

			ImplementationClass obj4 = new ImplementationClass();
			obj4.Add(10,20);

			((ITestInterface1)obj4).Sub(100,20);

			ITestInterface1 obj3 = new ImplementationClass();
			obj3.Add(200,50);
			obj3.Sub(200,50);

			Console.ReadKey();
		}
	}

interface ITestInterface1
{
	void Add(int num1, int num2);
	void Sub(int num1, int num2);
}
interface ITestInterface2 : ITestInterface1
{
	void Sub(int num1, int num2);
}

public class ImplementationClass1 : ITestInterface1
{
	public void Add(int num1, int num2)
	{
		Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
	}
	public void Sub(int num1, int num2)
        {
                Console.WriteLine($"Division of {num1} and {num2} is {num1 - num2}");
	}
}

public class ImplementationClass2 : ITestInterface2
{
        public void Add(int num1, int num2)
        {
                Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
	public void Sub(int num1, int num2)
        {
                Console.WriteLine($"Division of {num1} and {num2} is {num1 - num2}");
        }
}

public class ImplementationClass : ITestInterface1
{
        public void Add(int num1, int num2)
        {
                Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
	public void Sub(int num1, int num2)
        {
                Console.WriteLine($"Division of {num1} and {num2} is {num1 - num2}");
        }
}
}
