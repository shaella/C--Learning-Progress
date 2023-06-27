using System;
namespace PrototypeDesignPattern
{
	public class TemporaryEmployee : Employee2
	{
		public int FixedAmount { get; set; }
		public override Employee2 GetClone()
		{
			return (TemporaryEmployee)this.MemberwiseClone();
		}
		public override void ShowDetails()
		{
			Console.WriteLine("Temporary Employee");
			Console.WriteLine($" Name:{this.Name2}, Department: {this.Department2}, Type: {this.Type2}, FixedAmount: {this.FixedAmount}\n");
		}
	}
}
