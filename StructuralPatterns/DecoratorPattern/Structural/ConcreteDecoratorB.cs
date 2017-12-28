using System;

namespace Structural
{
	/// <summary>
	/// The 'ConcreteDecoratorB' class
	/// </summary>
	public class ConcreteDecoratorB : Decorator
	{
		public override void Operation()
		{
			base.Operation();
			AddedBehavior();
			Console.WriteLine("ConcreteDecoratorB.Operation()");
		}

		private void AddedBehavior()
		{
			Console.WriteLine("Adding new behavior");
		}
	}
}
