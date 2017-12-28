using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Facade Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point to the console application
		/// </summary>
        static void Main(string[] args)
        {
            Facade facade = new Facade();

			facade.MethodA();
			facade.MethodB();
			
			// Wait for user
			Console.ReadKey();
        }
    }
}
