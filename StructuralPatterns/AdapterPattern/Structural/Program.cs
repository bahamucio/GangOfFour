using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Adapter Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Create adapter and place a request
			Target target = new Adapter();
			target.Request();
	
			// Wait for user
			Console.ReadKey();
        }
    }
}
