using System;

namespace RealWorld
{
	/// <summary>
	/// The 'ProductB2' class
	/// </summary>
	public class Wolf : Carnivore
	{
		public override void Eat(Herbivore herbivore)
		{
			// Eat Bison
			Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
		}
	}
}
