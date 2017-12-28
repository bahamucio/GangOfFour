using System;

namespace Structural
{
	/// <summary>
	/// The 'ConcreteComponent' class
	/// </summary>
	public class ConcreteComponent : Component
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteComponent.Operation()");
		}
	}	
}
