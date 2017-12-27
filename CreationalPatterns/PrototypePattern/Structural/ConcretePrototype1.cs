using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcretePrototype' class
	/// </summary>
	public class ConcretePrototype1 : Prototype
	{
		public ConcretePrototype1(string id) : base(id)
		{

		}

		public override Prototype Clone()
		{
			return (Prototype)this.MemberwiseClone();
		}
	}
}
