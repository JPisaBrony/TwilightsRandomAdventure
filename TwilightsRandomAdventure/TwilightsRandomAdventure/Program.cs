using System;

namespace TwilightsRandomAdventure
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to Twilight Sparkles Random Adventure");
			Console.WriteLine ();

			Menu MainMenu = new Menu ("Main Menu", "Start", "Quit");
			MainMenu.printMenu ();

			Selection mainSelection = new Selection ();
		}
	}
}
