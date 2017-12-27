using System;
namespace RealWorld
{
	/// <summary>
	/// A 'Terminal expression' class
	/// <remarks>
	/// Hundred checks for C, CD, D or CM
	/// </remarks>
	/// </summary> 
	public class HundredExpression : Expression
	{
		public override string One() => "C";
		public override string Four() => "CD";
		public override string Five() => "D";
		public override string Nine() => "CM";
		public override int Multiplier() => 100;
	}
}
