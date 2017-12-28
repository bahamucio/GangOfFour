using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcreteImplementor' class
	/// </summary>
	public class ConcreteImplementorB : Implementor
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteImplementorB Operation()");
		}
	}
}
