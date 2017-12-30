using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	public class ConcreteStrategyA : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
		}
	}
}
