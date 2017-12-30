using System; 

namespace RealWorld
{
	/// <summary>
	/// The 'ConcreteObserver' class
	/// </summary>
	public class Investor : IInvestor
	{
		private string _name;
		private Stock _stock;

		public Investor(string name)
		{
			_name = name;
		}

		public void Update(Stock stock)
		{
			Console.WriteLine("Notified {0} of {1}'s change to {2:C}", _name, stock.Symbol, stock.Price);
		}

		// Gets or sets the stock
		public Stock Stock
		{
			get { return _stock; }
			set { _stock = value; }
		}
	}
}
