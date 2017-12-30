using System.Collections.Generic;
	
namespace Structural
{
	/// <summary>
	/// The 'ObjectStructure' class
	/// </summary>
	public class ObjectStructure
	{
		private List<Element> _elements = new List<Element>();

		public void Attach(Element element)
		{
			_elements.Add(element);
		}

		public void Detach(Element element)
		{
			_elements.Remove(element);
		}

		public void Accept(Visitor visitor)
		{
			foreach(Element e in _elements)
			{
				e.Accept(visitor);
			}
		}
	}
}
