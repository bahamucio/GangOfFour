using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Template method Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            DataAccessObject daoCategories = new Categories();
			daoCategories.Run();

			DataAccessObject daoProducts = new Products();
			daoProducts.Run();

			// Wait for user
			Console.ReadKey();
        }
    }
}
