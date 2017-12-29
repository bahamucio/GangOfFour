namespace Structural
{
	/// <summary>
	/// The 'ConcreteCommand' class
	/// </summary>
	public class ConcreteCommand : Command
	{
		public ConcreteCommand(Receiver receiver) : base(receiver)
		{
		
		}
		
		public override void Execute()
		{
			receiver.Action();
		}
	}
}
