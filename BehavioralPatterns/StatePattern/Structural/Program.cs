using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// State Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Setup context in a state
			Context c = new Context(new ConcreteStateA());

			// Issue requests which toggles state
			c.Request();
			c.Request();
			c.Request();
			c.Request();

			// Wait for user
			Console.ReadKey();
        }
    }
}
