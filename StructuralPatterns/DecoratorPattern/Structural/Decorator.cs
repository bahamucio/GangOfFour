using System;

namespace Structural
{
	/// <summary>
	/// The 'Decorator' class
	/// </summary>
	public class Decorator : Component
	{
		protected Component component;

		public void SetComponent(Component component)
		{
			this.component = component;
		}

		public override void Operation()
		{
			if(component != null)
				component.Operation();
		}
	}
}
