using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Receiver' class
	/// </summary>
	public class Calculator
	{
		private int _curr = 0;
	
		public void Operation(char @operator, int operand)
		{
			switch(@operator)
			{
				case '+':
					_curr += operand;
					break;
				case '-':
					_curr -= operand;
					break;
				case '*':
					_curr *= operand;
					break;
				case '/':
					_curr /= operand;
					break;
				default: throw new ArgumentException();
			}
			Console.WriteLine("Current value = {0,3} (following {1} {2})", _curr, @operator, operand);
		}
	}
}
