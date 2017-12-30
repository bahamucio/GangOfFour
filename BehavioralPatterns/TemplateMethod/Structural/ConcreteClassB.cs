using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcreteClass' class
	/// <summary>
	public class ConcreteClassB : AbstractClass
	{
		public override void PrimitiveOperation1()
		{
			Console.WriteLine("Called ConcreteClassB.PrimitiveOperation1()");
		}

		public override void PrimitiveOperation2()
		{
			Console.WriteLine("Called ConcreteClassB.PrimitiveOperation2()");
		}
	}
}
