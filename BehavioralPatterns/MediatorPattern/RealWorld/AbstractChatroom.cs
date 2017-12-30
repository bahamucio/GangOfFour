namespace RealWorld
{
	/// <summary>
	/// The 'Mediator' abstract class
	/// </summary>
	public abstract class AbstractChatroom
	{
		public abstract void Register(Participant participant);
		public abstract void Send(string from, string to, string message);
	}
}
