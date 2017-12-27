using System;
namespace RealWorld
{
	/// <summary>
	/// The 'Context' class
	/// </summary>
	public class Context
	{
		private string _input;
		private int _output;

		// Constructor
		public Context(string input)
		{
			_input = input;
		}

		// Gets or Sets the input
		public string Input 
		{
			get { return _input; }
			set { _input = value; }
		}		
		// Gets or Sets the output
		public int Output
		{
			get { return _output; }
			set { _output = value; }
		}
	}
}
