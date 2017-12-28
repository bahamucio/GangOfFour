using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Subsystem ClassB' class
	/// </summary>
	public class Credit
	{
		public bool HasGoodCredit(Customer c)
		{
			Console.WriteLine("Check credit for " + c.Name);
			return true;
		}
	}
}
