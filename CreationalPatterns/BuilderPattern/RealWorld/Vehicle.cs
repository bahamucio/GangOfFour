using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// The 'Product' class
	/// </summary>
	public class Vehicle
	{
		private string _vehicleType;
		private Dictionary<string,string> _parts = 
								new Dictionary<string,string>();

		public Vehicle(string vehicleType)
		{
			_vehicleType = vehicleType;
		}

		public string this[string key]
		{
			get
			{
				return _parts[key];
			}
			set
			{
				_parts[key] = value;
			}
		}

		public void Show()
		{
			Console.WriteLine("\n---------------------------- ");
			Console.WriteLine("Vehicle type: {0}", _vehicleType);
			Console.WriteLine("\tFrame: {0}", _parts["frame"]);
			Console.WriteLine("\tEngine: {0}", _parts["engine"]);
			Console.WriteLine("\t#Doors: {0}", _parts["doors"]);
			Console.WriteLine("\t#Wheels: {0}", _parts["wheels"]); 
		}
	}
}
