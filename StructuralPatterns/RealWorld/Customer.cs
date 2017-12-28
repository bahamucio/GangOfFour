namespace RealWorld
{
	/// <summary>
	/// The 'Customer' class
	/// </summary>
	public class Customer
	{
		private string _name;

		public Customer(string name)
		{
			_name = name;
		}

		public string Name
		{
			get { return _name; }
		}
	}
}
