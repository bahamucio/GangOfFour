using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Leaf' class
	/// </summary>
	public class PrimitiveElement : DrawingElement
	{
		public PrimitiveElement(string name) : base(name)
		{
		}

		public override void Add(DrawingElement d)
		{
			Console.WriteLine("Cannot add to leaf element.");
		}

		public override void Remove(DrawingElement d)
		{
			Console.WriteLine("Cannot remove from a leaf element.");
		}

		public override void Display(int indent)
		{
			Console.WriteLine(new string('-', indent) + " " + name);
		}
	}
}
