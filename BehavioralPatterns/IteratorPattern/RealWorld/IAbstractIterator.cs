namespace RealWorld
{
	/// <summary>
	/// The 'Iterator' inteface
	/// </summary>
	public interface IAbstractIterator
	{
		Item First();
		Item Next();
		bool IsDone { get; }
		Item CurrentItem { get; }
	}
}
