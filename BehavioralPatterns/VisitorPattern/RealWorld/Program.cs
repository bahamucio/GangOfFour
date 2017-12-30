using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Visitor Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Setup employees collection
			Employees e = new Employees();
			e.Attach(new Clerk());
			e.Attach(new Director());
			e.Attach(new President());

			// Employees are 'visited'
			e.Accept(new IncomeVisitor());
			e.Accept(new VacationVisitor());

			// Wait for user
			Console.ReadKey();
        }
    }
}
