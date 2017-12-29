using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Proxy Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Create MathProxy
			MathProxy proxy = new MathProxy();

			// Do the math
			Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
			Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
			Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
			Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

			// Wait for user
			Console.ReadKey();
        }
    }
}
