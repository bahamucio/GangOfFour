using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Singleton Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Constructor is protected - cannot use 'new'
			Singleton s1 = Singleton.Instance();
			Singleton s2 = Singleton.Instance();

			if(s1 == s2)
				Console.WriteLine("Objects are the same instance");

			// Wait for user
			Console.ReadKey();
        }
    }
}
