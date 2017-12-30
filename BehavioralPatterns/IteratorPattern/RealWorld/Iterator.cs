namespace RealWorld
{
	/// <summary>
	/// The 'ConcreteIterator' class
	/// </summary>
	public class Iterator : IAbstractIterator
	{
		private Collection _collection;
		private int _current = 0;
		private int _step = 1;
	
		public Iterator(Collection collection)
		{
			_collection = collection;
		}

		// Gets first item
		public Item First()
		{
			_current = 0;
			return _collection[_current] as Item;
		}

		// Gets next item
		public Item Next()
		{
			_current += _step;
			if(!IsDone)
			{
				return _collection[_current] as Item;
			}
			else
			{
				return null;
			}
		}

		// Gets or sets stepsize
		public int Step
		{
			get { return _step; }
			set { _step = value; }
		}

		// Gets the current iterator item
		public Item CurrentItem
		{
			get { return _collection[_current] as Item; }
		}

		// Gets whether the iterator is complete
		public bool IsDone
		{
			get { return _current >= _collection.Count; }
		}
	}
}