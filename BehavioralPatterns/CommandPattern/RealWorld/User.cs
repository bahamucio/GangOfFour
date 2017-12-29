using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// The 'Invoker' class
	/// </summary>
	public class User
	{
		private Calculator _calculator = new Calculator();
		private List<Command> _commands = new List<Command>();
		private int _current = 0;

		public void Redo(int levels)
		{
			Console.WriteLine("\nRedo ---- {0} levels ", levels);
			// Perform redo operations
			for(int i = 0; i < levels; i++)
			{
				if(_current < _commands.Count - 1)
				{
					Command c = _commands[_current++];
					c.Execute();
				}
			}
		}

		public void Undo(int levels)
		{
			Console.WriteLine("\nUndo ---- {0} levels ", levels);
			// Perform undo operations
			for (int i = 0; i < levels; i++)
			{
				if(_current > 0)
				{
					Command c = _commands[--_current];
					c.UnExecute();
				}
			}
		}

		public void Compute(char @operator, int operand)
		{
			// Create command operation and execute it
			Command command = new CalculatorCommand(_calculator, @operator, operand);
			command.Execute();
			// Add command to undo list
			_commands.Add(command);
			_current++;
		}
	}
}
