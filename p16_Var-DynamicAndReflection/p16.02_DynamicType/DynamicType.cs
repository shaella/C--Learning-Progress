using System;

class Program
{
	static void Main(string[] args)
	{
//		dynamic str = "Hello";
//		Console.WriteLine(str.GetType());
//		str++;

		long l = 50;
		int i = (int) l;
		Console.WriteLine($"int i = {i} & long l = {l}");

		dynamic str = "Dynamic Keyword in C#";
		Console.WriteLine(str.ToUpper());
		
//		str.SomeMethod(); // String does not have SomeMethod()

		Console.WriteLine($"Type is {str.GetType()} & value = {str}");

		dynamic I = 50;
		Console.WriteLine($"Type is {I.GetType()} & value = {I}");


		int int1 = 50;
		dynamic dynamic1 = int1;
		Console.WriteLine($"int1 = {int1} & dynamic1 = {dynamic1}");

		dynamic dynamic2 = 100;
		int int2 = dynamic2;
		Console.WriteLine($"int2 = {int2} & d2 = {dynamic2}");


		Student student1 = new Student()
		{
			Name = "Anurag",
			     Barnch = "CSE",
			     Roll = 1001
		};

		dynamic dynamicStudent = student1;

		Console.WriteLine($"Name = {dynamicStudent.Name}");
		Console.WriteLine($"Barnch = {dynamicStudent.Barnch}");
		Console.WriteLine($"Roll = {dynamicStudent.Roll}");


		dynamic dynamicStudent2 = new Student()
		{
			Name = "Anurag",
			     Barnch = "CSE",
			     Roll = 1001
		};

		Student student2 = dynamicStudent2;

		Console.WriteLine($"Name = {student2.Name}");
		Console.WriteLine($"Barnch = {student2.Barnch}");
		Console.WriteLine($"Roll = {student2.Roll}");


		int int6 = 500;
		double double6 = int6;
		Console.WriteLine($"int6 = {int6} & double6 = {double6}");

		int int7 = 200;
		long long6 = int7;
		Console.WriteLine($"int7 = {int7} & long6 = {long6}");

		int int8 = 100;
		dynamic dynamic6 = int8;
		double double7 = dynamic6;
		Console.WriteLine($"int8 = {int8} & dynamic6 = {dynamic6} & double7 = {double7}");

		int int9 = 200;
		dynamic dynamic7 = int9;
		long long7 = dynamic7;
		Console.WriteLine($"int9 = {int9} & dynamic7 = {dynamic7} & long7 = {long7}");


		double double11 = 4000;

		int int11 = (int)double11;
		Console.WriteLine($"double11 = {double11} & int11 = {int11}");
		
		double double12 = 4000;
		dynamic dynamicDouble11 = double12;
		int int12 = (int)dynamicDouble11;
		Console.WriteLine($"double12 = {double12} & dynamicDouble11 = {dynamicDouble11} && int12 = {int12}");


		DisplayValue("Dynamic in C#");
		DisplayValue(true);
		DisplayValue(5000);
		DisplayValue(111.50);
		DisplayValue(DateTime.Now);


		Calculator calculator = new Calculator();
		
		var result = calculator.GetType().InvokeMember("Add",
				System.Reflection.BindingFlags.InvokeMethod,
				null,
				calculator,
				new object[] {10, 20 });

		Console.WriteLine($"Sum = {result}");


		dynamic calculator2 = new Calculator();
		var result2 = calculator2.Add(10, 20);
		Console.WriteLine($"Sum = {result2}");
			
		Console.ReadKey();
	}

	public static void DisplayValue(dynamic val)
	{
		Console.WriteLine(val);
	}
}
public class Student
{
	public string Name { get; set; }
	public string Barnch { get; set; }
	public long Roll { get; set; }
}


public class Calculator
{
	public int Add(int number1, int number2)
	{
		return number1 + number2;
	}
}
