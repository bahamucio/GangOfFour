using System;

namespace Structural
{
	/// <summary>
	/// The 'ConcreteHandler3' class
	/// </summary>
	public class ConcreteHandler3 : Handler
	{
		public override void HandleRequest(int request)
		{
			if(request >= 20 && request < 30)
			{
				Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
			}
			else if(successor != null)
			{
				successor.HandleRequest(request);
			}
		}
	}
}
