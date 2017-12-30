using System;

namespace Structural
{
	/// <summary>
	/// The 'Context' class
	/// </summary>
	public class Context
	{
		private State _state;

		public Context(State state)
		{
			_state = state;
		}
	
		// Gets or sets the state
		public State State
		{
			get { return _state; }
			set
			{
				_state = value;
				Console.WriteLine("State: " + _state.GetType().Name);
			}
		}

		public void Request()
		{
			_state.Handle(this);
		}
	}
}
