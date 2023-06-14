using System;
using System.Collections.Generic;
namespace Enums
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] EnumValues = (int[])Enum.GetValues(typeof(Gender));
			Console.WriteLine("Gender Enum Values");
			foreach (int value in EnumValues)
			{
				Console.WriteLine(value);
			}
			Console.WriteLine();
			string[] EnumNames = Enum.GetNames(typeof(Gender));
			Console.WriteLine("Gender Enum Names");
			foreach (string Name in EnumNames)
                        {
                                Console.WriteLine(Name);
                        }

			
			List<Employee> empList = new List<Employee>
			{
				new Employee() { Name = "Anurag", Gender = 0 },
				    new Employee() { Name = "Pranaya", Gender = 1 },
				    new Employee() { Name = "Priyanka", Gender = 2 },
				    new Employee() { Name = "Sambit", Gender = 3 },
			};
			
			foreach (var emp in empList)
			{
				Console.WriteLine($"Name = {emp.Name} && Gender = {GetGender(emp.Gender)}");
			}

			Gender gender = (Gender)Season.Winter;
			Console.WriteLine(gender);
			Console.ReadLine();
		}

		public static string GetGender(int gender)
		{
			switch (gender)
			{
//				case 0:
//					return "Unknown";
//				case 1:
//					return "Male";
//				case 2:
//					return "Female";
//				default:
//					return "Invalid Data for Gender";
				case (int)Gender.Unknown:
                                        return "Unknown";
                                case (int)Gender.Male:
                                        return "Male";
                                case (int)Gender.Female:
                                        return "Female";
                                default:
                                        return "Invalid Data for Gender";
			}
		}
	}

	public class Employee
	{
		public string Name { get; set; }
		public int Gender { get; set;}
	}

	public enum Gender : int
	{
		Unknown = 1,
		Male = 2,
		Female = 3
	}

	public enum Season : int
	{
		Winter = 1,
		Spring = 2,
		Summer = 3
	}
}


