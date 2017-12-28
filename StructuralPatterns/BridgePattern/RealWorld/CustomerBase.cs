using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Abstraction' class
	/// </summary>
	public class CustomerBase
	{
		private DataObject _dataObject;
		protected string group;

		public CustomerBase(string group)
		{
			this.group = group;
		}

		public DataObject Data
		{
			get { return _dataObject; }
			set { _dataObject = value; }
		}

		public virtual void Next()
		{
			_dataObject.NextRecord();
		}

		public virtual void Prior()
		{
			_dataObject.PriorRecord();
		}

		public virtual void Add(string customer)
		{
			_dataObject.AddRecord(customer);
		}

		public virtual void Delete(string customer)
		{
			_dataObject.DeleteRecord(customer);
		}

		public virtual void Show()
		{
			_dataObject.ShowRecord();
		}

		public virtual void ShowAll()
		{
			Console.WriteLine("Customer group: " + group);
			_dataObject.ShowAllRecords();
		}
	} 
}
