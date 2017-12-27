using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcreteCreator' class
	/// </summary>
	public class ConcreteCreatorB : Creator
	{
		public override Product FactoryMethod()
		{
			return new ConcreteProductB();
		}
	}
}
