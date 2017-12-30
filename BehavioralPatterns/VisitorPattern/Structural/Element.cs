namespace Structural
{
	/// <summary>
	/// The 'Element' abstract class
	/// </summary>
	public abstract class Element
	{
		public abstract void Accept(Visitor visitor);
	}
}
