using System;

namespace Structural
{
	/// <summary>
	/// A 'ConcreteVisitor' class
	/// </summary>
	public class ConcreteVisitor1 : Visitor
	{
		public override void VisitConcreteElementA(ConcreteElementA element)
		{
			Console.WriteLine("{0} was visited by {1}", element.GetType().Name, this.GetType().Name);
		}

		public override void VisitConcreteElementB(ConcreteElementB element)
		{
			Console.WriteLine("{0} was visited by {1}", element.GetType().Name, this.GetType().Name); 
		}
	}
}
