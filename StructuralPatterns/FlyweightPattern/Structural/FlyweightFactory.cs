using System;
using System.Collections;

namespace Structural
{
	/// <summary>
	/// The 'FlyweightFactory' class
	/// </summary>
	public class FlyweightFactory
	{
		private Hashtable _flyweights = new Hashtable();

		public FlyweightFactory()
		{
			_flyweights.Add("X", new ConcreteFlyweight());
			_flyweights.Add("Y", new ConcreteFlyweight());
			_flyweights.Add("Z", new ConcreteFlyweight());
		}

		public Flyweight GetFlyweight(string key)
		{
			return ((Flyweight)_flyweights[key]);
		}
	}
}
