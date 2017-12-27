using System;

namespace Structural
{
	/// <summary>
	/// The 'NonTerminalExpression' class
	/// </summary>
	public class NonTerminalExpression : AbstractExpression
	{
		public override void Interpret(Context context)
		{
			Console.WriteLine("Calling NonTerminal.Interpret().");
		}
	}
}
