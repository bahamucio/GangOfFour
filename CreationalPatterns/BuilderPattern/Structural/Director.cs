using System;

namespace Structural
{
	/// <summary>
	/// The 'Director' class
	/// </summary>
	public class Director
	{
		public void Construct(Builder builder)
		{
			builder.CreatePartA();
			builder.CreatePartB();
		}
	}
}
