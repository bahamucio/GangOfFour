using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Strategy Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point info console application
		/// </summary>
        static void Main(string[] args)
        {
            Context context;

			// Three contexts following different strategies
			context = new Context(new ConcreteStrategyA());
			context.ContextInterface();

			context = new Context(new ConcreteStrategyB());
			context.ContextInterface();

			context = new Context(new ConcreteStrategyC());
			context.ContextInterface();

			// Wait for user
			Console.ReadKey();
        }
    }
}
