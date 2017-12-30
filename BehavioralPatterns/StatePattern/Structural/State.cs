namespace Structural
{
	/// <summary>
	/// The 'State' abstract class
	public abstract class State
	{
		public abstract void Handle(Context context);
	}
}
