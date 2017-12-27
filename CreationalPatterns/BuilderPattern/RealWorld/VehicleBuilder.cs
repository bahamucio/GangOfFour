using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Builder' abstract class
	/// </summary>
	public abstract class VehicleBuilder
	{
		protected Vehicle vehicle;

		public Vehicle Vehicle => vehicle;

		// Abstract build methods
		public abstract void BuildFrame();
		public abstract void BuildEngine();
		public abstract void BuildWheels();
		public abstract void BuildDoors();		
	}
}
