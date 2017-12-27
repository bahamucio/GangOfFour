using System;

namespace RealWorld
{
	/// <summary>
	/// A 'TerminalExpression' class
	/// <remarks>
	/// One checks for I, II, III, IV, V, VI, VII, VIII, IX
	/// </remarks>
	/// </summary>
	public class OneExpression : Expression
	{
		public override string One() => "I";
		public override string Four() => "IV";
		public override string Five() => "V";
		public override string Nine() => "IX";
		public override int Multiplier() => 1;
	}
}
