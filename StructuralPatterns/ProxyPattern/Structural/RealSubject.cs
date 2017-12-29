using System;

namespace Structural
{
	/// <summary>
	/// The 'RealSubject' class
	/// </summary>
	public class RealSubject : Subject
	{
		public override void Request()
		{
			Console.WriteLine("Called RealSubject.Request()");
		}
	}
}
