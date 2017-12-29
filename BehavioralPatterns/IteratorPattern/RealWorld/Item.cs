namespace RealWorld
{
	/// <summary>
	/// A collection item
	/// </summary>
	public class Item
	{
		private string _name;

		public Item(string name)
		{
			_name = name;
		}

		public string Name
		{
			get { return _name; }
		}
	}
}
