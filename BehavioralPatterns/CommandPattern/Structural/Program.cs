using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Command Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Create receiver, command and invoker
			Receiver receiver = new Receiver();
			Command command = new ConcreteCommand(receiver);
			Invoker invoker = new Invoker();

			// Set and execute command
			invoker.SetCommand(command);
			invoker.ExecuteCommand();

			// Wait for user
			Console.ReadKey();
        }
    }
}
