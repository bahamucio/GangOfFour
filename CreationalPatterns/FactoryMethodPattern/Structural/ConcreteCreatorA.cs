using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcreteCreator' class
	/// </summary>
	public class ConcreteCreatorA : Creator
	{
		public override Product FactoryMethod()
		{
			return new ConcreteProductA();
		}
	}
}
