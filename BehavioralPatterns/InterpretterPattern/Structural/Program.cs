using System;
using System.Collections;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Interpretter design pattern
	/// </summary>

    public class Program
    {
		/// <summary>
		/// Entry point to the console application
		/// </summary>
        static void Main(string[] args)
        {
     		Context context = new Context();

			// Usually a tree
			ArrayList list = new ArrayList();
			// Populate the 'abstract syntax tree'
			list.Add(new TerminalExpression());
			list.Add(new NonTerminalExpression());
			list.Add(new TerminalExpression());
			list.Add(new TerminalExpression());

			// Interpret
			foreach(AbstractExpression expr in list)
			{
				expr.Interpret(context);
			}

			// Wait for user
			Console.ReadKey();   	 	    
        }
    }
}
