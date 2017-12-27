using System;

namespace RealWorld
{
	/// <summary>
	/// The 'ProductB1' class
	/// </summary>
	public class Lion : Carnivore
	{
		public override void Eat(Herbivore herbivore)
		{
			// Eat Wildebeest
			Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
		}
	}
}
