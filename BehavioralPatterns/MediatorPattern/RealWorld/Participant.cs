using System;

namespace RealWorld
{
	/// <summary>
	/// The 'Abstract Colleague' class
	/// </summary>
	public class Participant
	{
		private Chatroom _chatroom;
		private string _name;

		public Participant(string name)
		{
			_name = name;
		}

		public string Name
		{
			get { return _name; }
		}

		public Chatroom Chatroom
		{
			get { return _chatroom; }
			set { _chatroom = value; }
		}

		// Send message to a given participant
		public void Send(string to, string message)
		{
			_chatroom.Send(_name, to, message);
		}

		// Receive message from given participant
		public virtual void Receive(string from, string message)
		{
			Console.WriteLine("{0} to {1}: '{2}'", from, Name, message);
		}
	}
}
