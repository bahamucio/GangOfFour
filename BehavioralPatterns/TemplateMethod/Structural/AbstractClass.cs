using System;

namespace Structural
{
	/// <summary>
	/// The "AbstractClass' abstract class
	/// </summary>
	public abstract class AbstractClass
	{
		public abstract void PrimitiveOperation1();
		public abstract void PrimitiveOperation2();

		public void TemplateMethod()
		{
			PrimitiveOperation1();
			PrimitiveOperation2();
			Console.WriteLine("");
		}
	}
}
