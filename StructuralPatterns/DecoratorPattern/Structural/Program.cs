using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Decorator Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
			// Create concrete component and two decorators
            ConcreteComponent c = new ConcreteComponent();
			ConcreteDecoratorA d1 = new ConcreteDecoratorA();
			ConcreteDecoratorB d2 = new ConcreteDecoratorB();

			// Link decorators
			d1.SetComponent(c);
			d2.SetComponent(d1);

			d2.Operation();
			
			// Wait for user
			Console.ReadKey();
        }
    }
}
