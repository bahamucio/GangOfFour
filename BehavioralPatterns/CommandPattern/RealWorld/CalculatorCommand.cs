using System;

namespace RealWorld
{
	/// <summary>
	/// The 'ConcreteCommand' class
	/// </summary>
	public class CalculatorCommand : Command
	{
		private char _operator;
		private int _operand;
		private Calculator _calculator;

		public CalculatorCommand(Calculator calculator, char @operator, int operand)
		{
			_operator = @operator;
			_calculator = calculator;
			_operand = operand;
		}

		public char Operator
		{
			set { _operator = value; }
		}

		public int Operand
		{
			set { _operand = value; }
		}

		// Execute new command
		public override void Execute()
		{
			_calculator.Operation(_operator, _operand);
		}

		public override void UnExecute()
		{
			_calculator.Operation(Undo(_operator), _operand);
		}

		// Return opposite operator for a given operator
		public char Undo(char @operator)
		{
			switch(@operator)
			{
				case '+': return '-';
				case '-': return '+';
				case '*': return '/';
				case '/': return '*';
				default: throw new ArgumentException("@operator");
			}
		}
	}
}
