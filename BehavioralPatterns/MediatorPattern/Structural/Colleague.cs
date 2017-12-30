namespace Structural
{
	/// <summary>
	/// The 'Colleague' abstract class
	/// </summary>
	public abstract class Colleague
	{
		protected Mediator mediator;
		
		public Colleague(Mediator mediator)
		{
			this.mediator = mediator;
		}
	}
}
