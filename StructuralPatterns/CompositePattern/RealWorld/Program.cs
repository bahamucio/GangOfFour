using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Composite Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Create a tree structure
			CompositeElement root = new CompositeElement("Picture");
			root.Add(new PrimitiveElement("Red line"));
			root.Add(new PrimitiveElement("Blue circle"));
			root.Add(new PrimitiveElement("Green box"));

			// Create a branch
			CompositeElement comp = new CompositeElement("Two circles");
			comp.Add(new PrimitiveElement("Black circle"));
			comp.Add(new PrimitiveElement("White circle"));
			root.Add(comp);

			// Add and remove primitive element
			PrimitiveElement pe = new PrimitiveElement("Yellow line");
			root.Add(pe);
			root.Remove(pe);

			// Recursively display nodes
			root.Display(1);

			// Wait for user
			Console.ReadKey();
        }
    }
}
