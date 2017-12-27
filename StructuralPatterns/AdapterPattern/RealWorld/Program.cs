using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Adapter Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Non-adapter chemical compound
			Compound unknown = new Compound("Unknown");
			unknown.Display();

			// Adapted chemical compounds
			Compound water = new RichCompound("Water");
			water.Display();

			Compound benzene = new RichCompound("Benzene");
			benzene.Display();

			Compound ethanol = new RichCompound("Ethanol");
			ethanol.Display();

			// Wait for user
			Console.ReadKey();
        }
    }
}
