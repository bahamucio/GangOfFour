using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Flyweight Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Build a document with text
			string document = "AAZZBBZB";
			char[] chars = document.ToCharArray();

			CharacterFactory factory = new CharacterFactory();
			
			// extrinsic state
			int pointSize = 10;

			// For each character use a flyweight object
			foreach(char c in chars)
			{
				pointSize++;
				Character character = factory.GetCharacter(c);
				character.Display(pointSize);
			}

			// Wait for user
			Console.ReadKey();
        }
    }
}
