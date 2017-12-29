using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Chain of Responsibility Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Setup Chain of responsibility
			Approver larry = new Director();
			Approver sam = new VicePresident();
			Approver tammy = new President();

			larry.SetSuccessor(sam);
			sam.SetSuccessor(tammy);

			// Generate and process purchase requests
			Purchase p = new Purchase(2034, 350.00, "Assets");
			larry.ProcessRequest(p);

			p = new Purchase(2035, 32590.10, "Project X");
			larry.ProcessRequest(p);

			p = new Purchase(2036, 122100.00, "Project Y");
			larry.ProcessRequest(p);

			// Wait for user
			Console.ReadKey();
        }
    }
}
