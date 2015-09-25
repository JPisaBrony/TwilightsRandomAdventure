using System;

namespace TwilightsRandomAdventure
{
	public class Character
	{
		public string name
		{
			get { return name; }
			set { name = value; }
		}

		public int health
		{
			get { return health; }
			set { health = value; }
		}

		public int damage
		{
			get { return damage; }
			set { damage = value; }
		}

		public Character (string n, int h, int d)
		{
			name = n;
			health = h;
			damage = d;
		}
	}
}

