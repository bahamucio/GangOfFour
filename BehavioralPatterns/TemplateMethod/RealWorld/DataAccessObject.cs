using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// The 'AbstractClass' abstract class
	/// </summary>
	public abstract class DataAccessObject
	{
		protected List<string> dataSet;

		public virtual void Connect()
		{
			Console.WriteLine("Connecting ... ");
		}

		public virtual void Disconnect()
		{
			Console.WriteLine("Disconnecting ... ");
			Console.WriteLine();
		}

		public abstract void Select();
		public abstract void Process();

		public void Run()
		{
			Connect();
			Select();
			Process();
			Disconnect();
		}
	}
}
