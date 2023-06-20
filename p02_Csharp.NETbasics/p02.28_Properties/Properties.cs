using System;
namespace Property
{
	public class Student
	{
		public int ID;
		public string Name;
		public int PassMark;
		private int _ID2;
		private string _Name2;
		private int _PassMark2 = 35;
		public void SetID(int ID2)
		{
			if (ID < 0)
			{
				throw new Exception("ID value should be greater than zero");
			}
			_ID2 = ID2;
		}
		public int GetID()
		{
			return _ID2;
		}
		public void SetName(string Name)
		{
			if (string.IsNullOrEmpty(Name))
			{
				throw new Exception("Name should not be empty");
			}
			_Name2 = Name2;
		}
		public string GetName()
		{
			if (string.IsNullOrEmpty(_Name2))
                        {
                                return "No Name";
                        }
                        return _Name2;
                }
		public int GetPassMark()
		{
			return _PassMark2;
		}


		public int ID2
                {
                        set
			{
			if (ID < 0)
                        {
                                throw new Exception("ID value should be greater than zero");
                        }
                        _ID2 = value;
			}
			get
			{
				return _ID2;
			}
                }
                public string Name2
                {
                        set
			{
			if (string.IsNullOrEmpty(Name2))
                        {
                                throw new Exception("Name should not be empty");
                        }
                        _Name2 = Name2;
			}
			get
			{
				return string.IsNullOrEmpty(_Name2) ? "No Name" : _Name2;
			}
                }
		public int PassMark2
		{
			get
			{
				return _PassMark2;
			}
		}
	}
	
	public class Employee
	{
		public int Id { get; set; }
		public int Age2 { get; set; }
		public string Name { get; set; }
		public string Address2 { get; set; }

		private int _EmpId, _Age;
		private string _EmpName, _Address;
		public int EmpId
		{
			set
			{
				_EmpId = value;
			}
			get
			{
				return _EmpId;
			}
		}
		public int Age
		{
			set
			{
				_Age = value;
			}
			get
			{
				return _Age;
			}
		}
		public string EmpName
		{
			set
			{
				_EmpName = value;
			}
			get
			{
				return _EmpName;
			}
		}
		public string Address
		{
			set
			{
				_Address = value;
			}
			get
			{
				return _Address;
			}
		}
	}
	public class Calculator
	{
		int _Number1, _Number2, _Result;
		public int SetNumber1
		{
			set
			{
				_Number1 = value;
			}
		}
		public int SetNumber2
		{
			set
			{
				_Number2 = value;
			}
		}
		public int GetResult
		{
			get
			{
				return _Result;
			}
		}
		public void Add()
		{
			_Result = _Number1 + _Number2;
		}
		public void Sub()
		{
			_Result = _Number1 - _Number2;
		}
		public void Mul()
		{
			_Result = _Number1 * _Number2;
		}
		public void Div()
		{
			_Result = _Number1 / _Number2;
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee();
			employee.EmpId = 101;
			employee.EmpName = "Pranaya";
			employee.Age = 101;
			employee.Address = "BBSR, Odisha, India";
			Console.WriteLine("Employee Details:");
			Console.WriteLine("Employee id:" + employee.EmpId);
			Console.WriteLine("Employee name:" + employee.EmpName);
			Console.WriteLine($"Id: {employee.EmpId}");
			Console.WriteLine($"Name: {employee.EmpName}");
			Console.WriteLine($"Address: {employee.Address}");
			Console.WriteLine($"Age: {employee.Age}");

			Calculator calculator = new Calculator();
			Console.WriteLine("Enter two Numbers:");
			calculator.SetNumber1 = int.Parse(Console.ReadLine());
			calculator.SetNumber2 = int.Parse(Console.ReadLine());
			calculator.Add();
			Console.WriteLine($"The Sum is: {calculator.GetResult}");
			calculator.Sub();
                        Console.WriteLine($"The Sub is: {calculator.GetResult}");
			calculator.Mul();
                        Console.WriteLine($"The Mul is: {calculator.GetResult}");
			calculator.Div();
                        Console.WriteLine($"The Div is: {calculator.GetResult}");
			employee.Id = 101;
			employee.Name = "Pranaya";
			employee.Address2 = "BBSR, Odisha, India";
			employee.Age = 101;
			Console.WriteLine("Employee Details:");
			Console.WriteLine($"Id: {employee.Id}");
                        Console.WriteLine($"Name: {employee.Name}");
                        Console.WriteLine($"Address: {employee.Address2}");
                        Console.WriteLine($"Age: {employee.Age2}");


			Student student = new Student();
			student.ID = 100;
			student.Name = null;
			student.PassMark = 0;
			Console.WriteLine($"ID = {student.ID}, Name = {student.Name}, PassMark = {student.PassMark}");
			student.SetID(101);
			student.SetName("Pranaya");
			Console.WriteLine($"ID = {student.GetID()}");
			Console.WriteLine($"Name = {student.GetName()}");
			Console.WriteLine($"Pass Mark = {student.GetPassMark()}");
			student.ID2 = 101;
			student.Name2 = "Pranaya";
			Console.WriteLine($"ID = {student.ID2}");
                        Console.WriteLine($"Name = {student.Name2}");
                        Console.WriteLine($"Pass Mark = {student.PassMark2}");

			Console.ReadKey();
		}
	}
}

