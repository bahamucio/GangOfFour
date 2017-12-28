using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Decorator' class
	/// </summary>
	public abstract class Decorator : LibraryItem
	{
		protected LibraryItem libraryItem;

		public Decorator(LibraryItem libraryItem)
		{
			this.libraryItem = libraryItem;
		}

		public override void Display()
		{
			libraryItem.Display();
		}
	}
}
