using System;
using System.Collections.Generic;
namespace Tules
{
	class Program
	{
		static void Main()
		{
			var values = new List<double>() { 10, 20, 30, 40, 50 };
			var result = Calculate(values);
			var(countResult, SumResult) = Calculate(values);
//			Tuple<int, double> t = Calculate(values);
//			Console.WriteLine($"There are {t.Item1} values and their sum is {t.Item2}");
			Console.WriteLine($"There are {result.Item1} values and their sum is {result.Item2}");
			Console.WriteLine($"There are {countResult} values and their sum is {SumResult}");
			Console.ReadKey();
		}
//		private static Tuple<int, double> Calculate(IEnumerable<double> values)
		private static (int count, double sum) Calculate(IEnumerable<double> values)
		{
			int count = 0;
			double sum = 0.0;
			foreach (var value in values)
			{
				count++;
				sum += value;
			}
//			Tuple<int, double> t = Tuple.Create(count, sum);
			return (count, sum);
		}
	}
}
