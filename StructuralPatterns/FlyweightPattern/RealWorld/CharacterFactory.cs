using System;
using System.Collections.Generic;

namespace RealWorld
{
	/// <summary>
	/// The 'FlyweightFactory' class
	/// </summary>
	public class CharacterFactory
	{
		private Dictionary<char, Character> _characters = 
				new Dictionary<char, Character>();

		public Character GetCharacter(char key)
		{
			// Uses "lazy" initialization
			Character character = null;
			if(_characters.ContainsKey(key))
			{
				character = _characters[key];
			}
			else
			{
				switch(key)
				{
					case 'A':
						character = new CharacterA();
						break;
					case 'B':
						character = new CharacterB();
						break;
					case 'Z':
						character = new CharacterZ();
						break;
					default:
						throw new ArgumentException();
				}
				_characters.Add(key, character);
			}
			return character;
		}
	}
}
