using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Component' abstract class
	/// </summary>
	public abstract class LibraryItem
	{
		private int _numCopies;

		public int NumCopies
		{
			get { return _numCopies; }
			set { _numCopies = value; }
		}

		public abstract void Display();
	}
}