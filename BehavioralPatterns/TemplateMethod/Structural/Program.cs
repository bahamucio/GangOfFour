using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Template Method Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            AbstractClass aA = new ConcreteClassA();
			aA.TemplateMethod();

			AbstractClass aB = new ConcreteClassB();
			aB.TemplateMethod();

			// Wait for user
			Console.ReadKey();
        }
    }
}
