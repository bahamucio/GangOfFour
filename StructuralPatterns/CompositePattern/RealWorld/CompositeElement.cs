using System;
using System.Collections.Generic;

namespace RealWorld
{
	public class CompositeElement : DrawingElement
	{
		private List<DrawingElement> _elements = new List<DrawingElement>();

		public CompositeElement(string name) : base(name)
		{
		}

		public override void Add(DrawingElement d)
		{
			_elements.Add(d);
		}

		public override void Remove(DrawingElement d)
		{
			_elements.Remove(d);
		}

		public override void Display(int indent)
		{
			Console.WriteLine(new string('-', indent) + " " + name);
			foreach(DrawingElement e in _elements)
			{
				e.Display(indent + 2);
			}
		}
	}
}
