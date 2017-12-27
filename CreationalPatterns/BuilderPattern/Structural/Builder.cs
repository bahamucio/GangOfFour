using System;

namespace Structural
{
	/// <summary>
	/// The 'Builder' abstract class
	/// </summary>
	public abstract class Builder
	{
		public abstract void CreatePartA();
		public abstract void CreatePartB();
		public abstract Product GetResult();
	}
}
