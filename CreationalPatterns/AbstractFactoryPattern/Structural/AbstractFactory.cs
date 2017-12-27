using System;

namespace Structural
{
	/// <summary>
	/// The 'AbstractFactory' abstract class
	/// </summary>
	public abstract class AbstractFactory 
	{
		public abstract AbstractProductA CreateProductA();
		public abstract AbstractProductB CreateProductB();
	}
}
