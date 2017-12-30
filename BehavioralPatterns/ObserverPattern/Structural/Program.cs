using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Observer Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();

			s.Attach(new ConcreteObserver(s, "X"));
			s.Attach(new ConcreteObserver(s, "Y"));
			s.Attach(new ConcreteObserver(s, "Z"));

			// Change subject and notify observers
			s.SubjectState = "ABC";
			s.Notify();

			// Wait for user
			Console.ReadKey();
        }
    }
}
