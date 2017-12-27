using System;

namespace Structural
{
	/// <summary>
	/// The 'ProductB1' class
	/// </summary>
	public class ProductB1 : AbstractProductB
	{
		public override void Interacts(AbstractProductA a)
		{
			Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
		}
	}
}
