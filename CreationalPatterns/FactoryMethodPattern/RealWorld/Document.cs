using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// The 'Creator' abstract class
	/// </summary>
	public abstract class Document
	{
		private List<Page> _pages = new List<Page>();

		// Constructor calls abstract Factory Method
		public Document()
		{
			CreatePages();
		}

		public List<Page> Pages 
		{
			get { return _pages; }
		}

		// Factory method
		public abstract void CreatePages();
	}
}
