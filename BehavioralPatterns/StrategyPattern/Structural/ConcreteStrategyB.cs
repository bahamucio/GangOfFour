using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	public class ConcreteStrategyB : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
		}
	}
}
