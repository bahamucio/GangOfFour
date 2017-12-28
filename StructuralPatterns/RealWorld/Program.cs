using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Facade Design Pattern
	/// </summary>
    class Program
    {	
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Facade
			Mortage mortage = new Mortage();
			
			// Evaluate mortage eligibility for customer
			Customer customer = new Customer("Ann McKinsey");
			bool eligible = mortage.IsEligible(customer, 125000);

			Console.WriteLine("\n" + customer.Name + 
					" has been " + (eligible ? "Approved" : "Rejected"));

			// Wait for user
			Console.ReadKey();
        }
    }
}
