using System;
namespace PrototypeDesignPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee2 emp21 = new PermanentEmployee()
			{
				Name2 = "Anurag",
					Department2 = "IT",
						   Type2 = "Permanent",
						   Salary = 100000
			};

			Employee2 emp212 = emp21.GetClone();

			emp212.Name2 = "Pranaya";
			emp212.Department2 = "HR";
			emp21.ShowDetails();
			emp212.ShowDetails();

			Employee2 emp31 = new TemporaryEmployee()
			{
				Name2 = "Preety",
				     Department2 = "HR",
				     Type2 = "Temporary",
				     FixedAmount = 200000
			};

			Employee2 emp4 = emp31.GetClone();

			emp4.Name2 = "Priyanka";
			emp4.Department2 = "Sales";
			emp31.ShowDetails();
			emp4.ShowDetails();
			
			Employee emp1 = new Employee();
			emp1.Name = "Anurag";
			emp1.Department = "IT";

			Employee emp2 = emp1;
			Employee emp3 = emp1.GetClone();
			emp3.Name = "Alex";

			emp2.Name = "Pranaya";

			Console.WriteLine("Employee 1: ");
			Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
			Console.WriteLine("Employee 2: ");
			Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);
			Console.WriteLine("Employee 3: ");
                        Console.WriteLine("Name: " + emp3.Name + ", Department: " + emp3.Department);

			Console.Read();
		}
	}

	public class Employee
	{
		public string Name { get; set; }
		public string Department { get; set; }

		public Employee GetClone()
		{
			return (Employee)this.MemberwiseClone();
		}
	}
}
