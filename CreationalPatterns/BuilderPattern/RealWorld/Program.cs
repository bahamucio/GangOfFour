using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Builder Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            VehicleBuilder builder;

			// Create shop with vehicle builders
			Shop shop = new Shop();
			
			// Construct and display vehicles
			builder = new ScooterBuilder();
			shop.Construct(builder);
			builder.Vehicle.Show();
			
			builder = new CarBuilder();
			shop.Construct(builder);
			builder.Vehicle.Show();
		
			builder = new MotorCycleBuilder();
			shop.Construct(builder);
			builder.Vehicle.Show();

			// Wait for user
			Console.ReadKey();
        }
    }
}
