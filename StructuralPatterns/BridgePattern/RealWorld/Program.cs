using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Bridge Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Create refined abstraction
			Customers customers = new Customers("Chicago");

			// Set concrete implementor
			customers.Data = new CustomersData();
			
			// Exercise the bridge
			customers.Show();
			customers.Next();
			customers.Show();
			customers.Next();
			customers.Show();
			customers.Add("Henry Velasquez");

			customers.ShowAll();
			
			// Wait for user
			Console.ReadKey();
        }
    }
}
