using System;

namespace Structural
{
	/// <summary>
	/// Program startup class for Structural
	/// Iterator Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
			a[0] = "Item A";
			a[1] = "Item B";
			a[2] = "Item C";
			a[3] = "Item D";

			// Create iterator and provide aggregate
			Iterator i = a.CreateIterator();
			
			Console.WriteLine("Iterate over collection: ");
			object item = i.First();
			while(item != null)
			{
				Console.WriteLine(item);
				item = i.Next();
			}
			
			// Wait for user
			Console.ReadKey();
        }
    }
}
