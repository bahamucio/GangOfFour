using System;

namespace Structural
{
	/// <summary>
	/// The 'Originator' class
	/// </summary>
	public class Originator
	{
		private string _state;

		public string State
		{
			get { return _state; }
			set
			{
				_state = value;
				Console.WriteLine("State = " + _state);
			}
		}

		// Creates memento
		public Memento CreateMemento()
		{
			return new Memento(_state);
		}

		// Restores the original state
		public void SetMemento(Memento memento)
		{
			Console.WriteLine("Restoring state ... ");
			State = memento.State;
		}
	}
}
