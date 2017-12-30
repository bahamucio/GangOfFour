using System;

namespace RealWorld
{
	/// <summary>
	/// The 'ConcreteElement' class
	/// </summary>
	public class Employee : Element
	{
		private double _income;
		private string _name;
		private int _vacationDays;

		public Employee(string name, double income, int vacationDays)
		{
			_income = income;
			_name = name;
			_vacationDays = vacationDays;
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public double Income
		{
			get { return _income; }
			set { _income = value; }
		}

		public int VacationDays
		{
			get { return _vacationDays; }
			set { _vacationDays = value; }
		}

		public override void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
