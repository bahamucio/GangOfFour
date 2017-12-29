using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Command Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Create user and let her compute
			User user = new User();

			// Users presses calculator buttons
			user.Compute('+', 100);
			user.Compute('-', 50);
			user.Compute('*', 10);
			user.Compute('/', 2);

			// Undo 4 commands
			user.Undo(4);
			// Redo 3 commands
			user.Redo(3);

			// Wait for user
			Console.ReadKey();
        }
    }
}
