using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	public class ConcreteStrategyC : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine("Called ConcreteStrategyC.AlgorithmInterface()");
		}
	}
}
