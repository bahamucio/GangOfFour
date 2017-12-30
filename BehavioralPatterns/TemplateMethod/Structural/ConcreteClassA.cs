using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcreteClass' class
	/// </summary>
	public class ConcreteClassA : AbstractClass
	{
		public override void PrimitiveOperation1()
		{
			Console.WriteLine("Called ConcreteClassA.PrimitiveOperation1()");
		}

		public override void PrimitiveOperation2()
		{
			Console.WriteLine("Called ConcreteClassA.PrimitiveOperation2()");
		}
	}
}
