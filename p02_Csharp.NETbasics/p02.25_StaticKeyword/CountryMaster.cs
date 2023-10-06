namespace StaticKeywordDemo
{
	public class CountryMaster
	{
		public string CountryCode { get; set; }
		public string CountryName { get; set; }
		private string ComputerName
		{
			get
			{
				return CommonTask.GetComputerName();
			}
		}

		public void Insert()
		{
			if (!CommonTask.IsEmpty(CountryCode) && !CommonTask.IsEmpty(CountryName))
			{
			}
		}
	}
}

