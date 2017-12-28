using System;

namespace Structural
{
	/// <summary>
	/// The 'RefinedAbstraction' class
	/// </summary>
	public class RefinedAbstraction : Abstraction
	{
		public override void Operation()
		{
			implementor.Operation();
		}
	}
}
