namespace PrototypeDesignPattern
{
	public abstract class Employee2
	{
		public string Name2 { get; set; }
		public string Department2 { get; set; }
		public string Type2 { get; set; }

		public abstract Employee2 GetClone();
		public abstract void ShowDetails();
	}
}
