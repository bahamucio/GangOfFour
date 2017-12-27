using System;

namespace Structural
{
	/// <summary>
	/// The 'Client' class. Interaction environment for the products.
	/// </summary>
	public class Client
	{
		private readonly AbstractProductA _abstractProductA;
		private readonly AbstractProductB _abstractProductB;

		// Constructor
		public Client(AbstractFactory factory)
		{
			_abstractProductA = factory.CreateProductA();
			_abstractProductB = factory.CreateProductB();
		}

		public void Run()
		{
			_abstractProductB.Interacts(_abstractProductA);
		}
	}
}
