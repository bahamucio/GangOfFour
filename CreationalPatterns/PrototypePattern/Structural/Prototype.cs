using System;

namespace Structural
{
	/// <summary>
	/// The 'Prototype' abstract class
	/// </summary>
	public abstract class Prototype
	{
		private string _id;

		public Prototype(string id)
		{
			_id = id;
		}

		public string Id
		{
			get { return _id; }
		}

		public abstract Prototype Clone();
	}
}
