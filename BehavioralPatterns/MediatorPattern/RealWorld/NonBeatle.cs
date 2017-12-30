using System;

namespace RealWorld
{
	/// <summary>
	/// A 'ConcreteColleague' class
	/// </summary>
	public class NonBeatle : Participant
	{
		public NonBeatle(string name) : base(name)
		{
		}

		public override void Receive(string from, string message)
		{
			Console.Write("To a NonBeatle: ");
			base.Receive(from, message);
		}
	}
}
