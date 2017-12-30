namespace Structural
{
	/// <summary>
	/// The 'Context' class
	/// </summary>
	public class Context
	{
		private Strategy _strategy;

		public Context(Strategy strategy)
		{
			_strategy = strategy;
		}

		public void ContextInterface()
		{
			_strategy.AlgorithmInterface();
		}
	}
}
