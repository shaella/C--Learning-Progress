using System;
namespace PrototypeDesignPattern
{
	public class PermanentEmployee : Employee2
	{
		public int Salary { get; set; }
		public override Employee2 GetClone()
		{
			return (PermanentEmployee)this.MemberwiseClone();
		}
		public override void ShowDetails()
		{
			Console.WriteLine("Permanent Employee");
			Console.WriteLine($" Name:{this.Name2}, Department2: {this.Department2}, Type:{this.Type2}, Salary: {this.Salary}\n");
		}
	}
}
