namespace Structural
{
	/// <summary>
	/// The 'Caretaker' class
	/// </summary>
	public class Caretaker
	{
		private Memento _memento;

		// Gets or sets memento
		public Memento Memento
		{
			get { return _memento; }
			set { _memento = value; }
		}
	}
}
