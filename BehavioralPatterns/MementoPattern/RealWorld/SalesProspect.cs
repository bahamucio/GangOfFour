using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Originator' class
	/// </summary>
	public class SalesProspect
	{
		private string _name;
		private string _phone;
		private double _budget;

		// Gets or sets the name
		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				Console.WriteLine("Name: " + _name);
			}
		}

		// Gets or sets the phone
		public string Phone
		{
			get { return _phone; }
			set
			{
				_phone = value;
				Console.WriteLine("Phone: " + _phone);
			}
		}

		// Gets or sets the budget
		public double Budget
		{
			get { return _budget; }
			set
			{
				_budget = value;
				Console.WriteLine("Budget: " + _budget);
			}
		}

		// Stores the memento
		public Memento SaveMemento()
		{
			Console.WriteLine("\nSaving state --\n");
			return new Memento(_name, _phone, _budget);
		}

		// Restores memento
		public void RestoreMemento(Memento memento)
		{
			Console.WriteLine("\nRestoring state --\n");
			Name = memento.Name;
			Phone = memento.Phone;
			Budget = memento.Budget;	
		}
	}
}
