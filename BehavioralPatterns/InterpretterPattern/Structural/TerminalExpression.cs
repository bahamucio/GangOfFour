using System;

namespace Structural
{
	/// <summary>
	/// The 'TerminalExpression' class
	/// </summary>
	public class TerminalExpression : AbstractExpression
	{
		public override void Interpret(Context context)
		{
			Console.WriteLine("Called Terminal.Interpret().");
		}
	}
}
