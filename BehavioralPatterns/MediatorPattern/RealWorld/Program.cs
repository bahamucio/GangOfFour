using System;

namespace RealWorld
{
	/// <summary>
	/// Program startup class for Real-World
	/// Mediator Design Pattern
	/// </summary>
    class Program
    {
		/// <summary>
		/// Entry point into console application
		/// </summary>
        static void Main(string[] args)
        {
            // Create a chatroom
			Chatroom chatroom = new Chatroom();
			// Create participants and register them
			Participant George = new Beatle("George");
			Participant Paul = new Beatle("Paul");
			Participant Ringo = new Beatle("Ringo");
			Participant John = new Beatle("John");
			Participant Yoko = new NonBeatle("Yoko");

			chatroom.Register(George);
			chatroom.Register(Paul);
			chatroom.Register(Ringo);
			chatroom.Register(John);
			chatroom.Register(Yoko);

			// Chatting participants
			Yoko.Send("John", "Hi, John!");
			Paul.Send("Ringo", "All you need is love.");
			Ringo.Send("George", "My sweet lord.");
			Paul.Send("John", "Can't buy me love.");
			John.Send("Yoko", "My sweet love.");

			// Wait for user
			Console.ReadKey();
        }
    }
}
