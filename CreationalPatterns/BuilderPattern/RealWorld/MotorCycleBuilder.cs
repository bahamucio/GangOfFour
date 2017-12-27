using System;

namespace RealWorld
{
	/// <summary>
	/// The 'ConcreteBuilder1' class
	/// </summary>
	public class MotorCycleBuilder : VehicleBuilder
	{
		public MotorCycleBuilder()
		{
			vehicle = new Vehicle("MotorCycle");
		}

		public override void BuildFrame()
		{
			vehicle["frame"] = "MotorCycle Frame";
		}

		public override void BuildEngine()
		{
			vehicle["engine"] = "500 cc";
		}
	
		public override void BuildDoors()
		{
			vehicle["doors"] = "0";
		}

		public override void BuildWheels()
		{
			vehicle["wheels"] = "2";
		}
	}
}