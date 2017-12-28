using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcteteImplementor' class
	/// </summary>
	public class ConcreteImplementorA : Implementor
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteImplementorA Operation()");
		}
	}
}
