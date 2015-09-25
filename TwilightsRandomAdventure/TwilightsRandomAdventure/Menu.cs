using System;
using System.Collections.Generic;

namespace TwilightsRandomAdventure
{
	public class Menu
	{
		private List<string> choices = new List<string>();
		private string name;

		public Menu (string menuName, params string[] list)
		{
			name = menuName;
			int counter = 1;
			foreach (string c in list) {
				choices.Add (counter + " " + c);
				counter++;
			}
		}

		public void printMenu() {
			Console.WriteLine (name);
			Console.WriteLine ();
			foreach (string c in choices)
				Console.WriteLine (c);
		}


	}
}

