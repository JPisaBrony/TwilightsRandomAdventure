using System;

namespace TwilightsRandomAdventure
{
	public class Selection
	{
		Boolean quit = false;
		int option;

		public Selection ()
		{
			
		}

		public void startSelection() {
			while (!quit) {
				if (Int32.TryParse (Console.ReadLine (), out option)) {
					switch (option) {
					case 1:
						Dungeon mainDungeon = new Dungeon ();
						break;
					case 2:
						quit = true;
						break;
					default:
						Console.WriteLine ("Invald Option");
						break;
					}
				} else {
					Console.WriteLine ("Boi, watcho trying to do");
				}
			}
		}
	}
}

