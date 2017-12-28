using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Bridge Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();
			
			// Set implementation and call
			ab.Implementor = new ConcreteImplementorA();
			ab.Operation();

			// Change implementor and call
			ab.Implementor = new ConcreteImplementorB();
			ab.Operation();

			// Wait for user
			Console.ReadKey();
        }
    }
}
