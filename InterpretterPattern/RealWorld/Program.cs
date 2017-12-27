using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Interpretter Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point to the console application
		/// </summary>
        static void Main(string[] args)
        {
            string roman = "MCMXXVIII";
			Context context = new Context(roman);
			// Build the 'parse' tree
			List<Expression> tree = new List<Expression>();
			tree.Add(new ThousandExpression());
			tree.Add(new HundredExpression());
			tree.Add(new TenExpression());
			tree.Add(new OneExpression());

			// Interpret
			foreach(Expression expr in tree)
			{
				expr.Interpret(context);
			}

			Console.WriteLine("{0} = {1}", roman, context.Output);

			// Wait user
			Console.ReadKey();
        }
    }
}
