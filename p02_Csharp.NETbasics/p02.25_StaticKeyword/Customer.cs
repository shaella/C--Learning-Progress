namespace StaticKeywordDemo
{
	public class Customer
	{
		public string CustomerCode { get; set; }
		public string CustomerName { get; set; }
		private string MachineName = "";
		
		public Customer()
		{
			MachineName = CommonTask.GetComputerName();
		}
		
		public void Insert()
		{
			if(!CommonTask.IsEmpty(CustomerCode) && !CommonTask.IsEmpty(CustomerName))
			{
			}
		}
	}
}
