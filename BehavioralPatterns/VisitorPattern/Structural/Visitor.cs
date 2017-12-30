namespace Structural
{
	/// <summary>
	/// The 'Visitor' abstract class
	/// </summary>
	public abstract class Visitor
	{
		public abstract void VisitConcreteElementA(ConcreteElementA element);
		public abstract void VisitConcreteElementB(ConcreteElementB element);
	}
}
