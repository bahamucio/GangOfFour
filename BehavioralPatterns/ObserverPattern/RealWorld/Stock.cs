using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// The 'Subject' abstract class
	/// </summary>
	public abstract class Stock
	{
		private string _symbol;
		private double _price;
		private List<IInvestor> _investors = new List<IInvestor>();

		public Stock(string symbol, double price)
		{
			_symbol = symbol;
			_price = price;
		}

		public void Attach(IInvestor investor)
		{
			_investors.Add(investor);
		}

		public void Detach(IInvestor investor)
		{
			_investors.Remove(investor);
		}

		public void Notify()
		{
			foreach(IInvestor i in _investors)
			{
				i.Update(this);
			}
			Console.WriteLine("");
		}
		
		// Gets or sets the price
		public double Price
		{
			get { return _price; }
			set
			{
				if(_price != value)
				{
					_price = value;
					Notify();
				}
			}
		}

		// Gets the symbol
		public string Symbol
		{
			get { return _symbol; }
		}
	}
}
