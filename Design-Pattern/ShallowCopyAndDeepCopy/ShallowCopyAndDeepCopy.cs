using System;
namespace ShallowCopyDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			ChooseEmployee emp5 = new ChooseEmployee()
			{
				ChooseName = "Anurag",
					   ChooseDepartment = "IT",
					   ChooseEmpAddress = new ChooseAddress() { strChooseAddress = "BBSR" }
			};
			ChooseEmployee emp6 = emp5.GetDeepCopy();
			emp6.ChooseName = "Pranaya";
			emp6.ChooseEmpAddress.strChooseAddress = "Mumbai";
			Console.WriteLine("Using Deep Copy");
			Console.WriteLine($" Employee 5: Name: {emp5.ChooseName}, Address: {emp5.ChooseEmpAddress.strChooseAddress}");
			Console.WriteLine($" Employee 6: Name: {emp6.ChooseName}, Address: {emp6.ChooseEmpAddress.strChooseAddress}");
			ChooseEmployee emp7 = new ChooseEmployee()
                        {
                                ChooseName = "Sambit",
                                           ChooseDepartment = "HR",
                                           ChooseEmpAddress = new ChooseAddress() { strChooseAddress = "Delhi" }
                        };
                        ChooseEmployee emp8 = emp7.GetShallowCopy();
                        emp8.ChooseName = "Hina";
                        emp8.ChooseEmpAddress.strChooseAddress =  "Hyderabad";
			Console.WriteLine("Using Shallow Copy");
			Console.WriteLine($" Employee 7: Name: {emp7.ChooseName}, Address: {emp7.ChooseEmpAddress.strChooseAddress}");
                        Console.WriteLine($" Employee 8: Name: {emp8.ChooseName}, Address: {emp8.ChooseEmpAddress.strChooseAddress}");


			DeepEmployee emp3 = new DeepEmployee
			{
				Name2 = "Anurag",
				      Department2 = "IT",
				      EmpAddress2 = new DeepAddress() { address2 = "BBSR" }
			};
			DeepEmployee emp4 = emp3.GetClone();
			emp4.Name2 = "Pranaya";
			emp4.EmpAddress2.address2 = "Mumbai";
			Console.WriteLine("Employee 3: ");
                        Console.WriteLine("Name: " + emp3.Name2 + ", Address: " + emp3.EmpAddress2.address2 + ", Dept: " + emp3.Department2);
                        Console.WriteLine("Employee 4: ");
                        Console.WriteLine("Name: " + emp4.Name2 + ", Address: " + emp4.EmpAddress2.address2 + ", Dept: " + emp4.Department2);

			
			Employee emp1 = new Employee
			{
				Name = "Anurag",
				     Department = "IT",
				     EmpAddress = new Address() { address = "BSSR" }
			};
			Employee emp2 = emp1.GetClone();
			emp2.Name = "Pranaya";
			emp2.EmpAddress.address = "Mumbai";
			Console.WriteLine("Employee 1: ");
			Console.WriteLine("Name: " + emp1.Name + ", Address: " + emp1.EmpAddress.address + ", Dept: " + emp1.Department);
			Console.WriteLine("Employee 2: ");
			Console.WriteLine("Name: " + emp2.Name + ", Address: " + emp2.EmpAddress.address + ", Dept: " + emp2.Department);

			Console.Read();
		}
	}

	public class Employee
	{
		public string Name { get; set; }
		public string Department { get; set; }
		public Address EmpAddress { get; set; }
		public Employee GetClone()
		{
			return (Employee)this.MemberwiseClone();
		}
	}

	public class DeepEmployee
        {
                public string Name2 { get; set; }
                public string Department2 { get; set; }
                public DeepAddress EmpAddress2 { get; set; }
                public DeepEmployee GetClone()
                {
                        DeepEmployee employee = (DeepEmployee)this.MemberwiseClone();
			employee.EmpAddress2 = EmpAddress2.GetClone();
			return employee;
                }
        }

	public class ChooseEmployee
        {
                public string ChooseName { get; set; }
                public string ChooseDepartment { get; set; }
                public ChooseAddress ChooseEmpAddress { get; set; }
                public ChooseEmployee GetShallowCopy()
                {
                        ChooseEmployee chosenemployee = (ChooseEmployee)this.MemberwiseClone();
                        return chosenemployee;
                }
		public ChooseEmployee GetDeepCopy()
		{
			ChooseEmployee chosendeepemployee = (ChooseEmployee)this.MemberwiseClone();
                        chosendeepemployee.ChooseEmpAddress = ChooseEmpAddress.GetClone();
                        return chosendeepemployee;
		}
        }
	
	public class ChooseAddress
	{
		public string strChooseAddress { get; set; }
                public ChooseAddress GetClone()
                {
                        return (ChooseAddress)this.MemberwiseClone();
		}
	}


	public class Address
        {
                public string address { get; set; }
        }

	public class DeepAddress
	{
		public string address2 { get; set; }
		public DeepAddress GetClone()
		{
			return (DeepAddress)this.MemberwiseClone();
		}
	}
}


