using System;

namespace Structural
{
	/// <summary>
	/// The 'ProductB2' class
	/// </summary>
	public class ProductB2 : AbstractProductB
	{
		public override void Interacts(AbstractProductA a)
		{
			Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
		}
	}
}
