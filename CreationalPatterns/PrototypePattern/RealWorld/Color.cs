using System;

namespace RealWorld
{
	/// <summary>
	/// The 'ConcretePrototype' class
	/// </summary>
	public class Color : ColorPrototype
	{
		private int _red;
		private int _green;
		private int _blue;

		public Color(int red, int green, int blue)
		{
			_red = red;
			_green = green;
			_blue = blue;
		}

		// Create a shallow copy
		public override ColorPrototype Clone()
		{
			Console.WriteLine("Clonning color RGB: {0,3},{1,3},{2,3}", _red, _green, _blue);

			return this.MemberwiseClone() as ColorPrototype;
		}
	}
}
