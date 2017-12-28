using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// The 'ConcreteDecorator' class
	/// </summary>
	public class Borrowable : Decorator
	{
		protected List<string> borrowers = new List<string>();

		public Borrowable(LibraryItem libraryItem) : base(libraryItem)
		{
		}

		public void BorrowItem(string name)
		{
			borrowers.Add(name);
			libraryItem.NumCopies--;
		}
		
		public void ReturnItem(string name)
		{
			borrowers.Remove(name);
			libraryItem.NumCopies++;
		}

		public override void Display()
		{
			base.Display();
			foreach(string b in borrowers)
			{
				Console.WriteLine(" borrower: " + b);
			}
		}		
	}
}