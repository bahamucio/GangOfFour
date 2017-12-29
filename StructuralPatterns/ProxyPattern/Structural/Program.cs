using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Proxy Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Create proxy and request a service
			Proxy proxy = new Proxy();
			proxy.Request();

			// Wait for user
			Console.ReadKey();
        }
    }
}
