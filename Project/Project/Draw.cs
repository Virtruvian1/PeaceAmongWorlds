using System;
using System.Linq;
using System.Collections.Generic;

namespace Project
{ 
	public class Draw
	{

		public Draw()
		{
		}


		
		
		public void DrawPlanets(MenuLink menuLink)
		{
			
			Console.Title = "PEACE AMOUNG WORLDS!!!";
			Console.SetWindowSize(150, 40);
			Earth("Earth", 75, 76, 77, 78, 15, 16);
			LV426("LV426", 27, 28, 29, 30, 9, 10);
			Tatooine("Tatooine", 100, 101, 102, 103, 19, 20);
			Klandathu("Klandathu", 25, 26, 27, 28, 23, 24);
			Lavatory("Lavatory", 65, 66, 67, 68, 37, 38);
			DeathStar("DeathStar", 130, 131, 132, 133, 5, 6);
			LV223("LV223", 27, 28, 29, 30, 15, 16);
			Hoth("Hoth", 100, 101, 102, 103, 24, 25);
			PlanetP("Planet P", 33, 34, 35, 36, 30, 31);
			Waititi("Waititi", 80, 81, 82, 83, 37, 38);

			void Earth(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
			{
				int ID = 0;
				DrawPlanet(X1, X2, X3, X4, Y1, Y2, ID);
			}
			void LV426(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
			{
				int ID = 1;
				DrawPlanet(X1, X2, X3, X4, Y1, Y2, ID);
			}
			void Tatooine(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
			{
				int ID = 2;
				DrawPlanet(X1, X2, X3, X4, Y1, Y2, ID);
			}
			void Klandathu(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
			{
				int ID = 3;
				DrawPlanet(X1, X2, X3, X4, Y1, Y2, ID);
			}
			void Lavatory(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
			{
				int ID = 4;
				DrawPlanet(X1, X2, X3, X4, Y1, Y2, ID);
			}
			void DeathStar(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
			{
				var result = menuLink.Rick.mapPieces.All(v => v);
				if (result)
				{
					int ID = 5;
					DrawPlanet(X1, X2, X3, X4, Y1, Y2, ID);
				}
			}
			// Main Enemy Planets
			void LV223(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
			{
				if (menuLink.planets[1].Leader.mission == true && menuLink.Rick.artifact[1] == false)
				{
					int ID = 5;
					DrawPlanet(X1, X2, X3, X4, Y1, Y2, ID);
				};

			}
			void Hoth(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
			{
				if (menuLink.planets[2].Leader.mission == true && menuLink.Rick.artifact[2] == false)
				{
					int ID = 5;
					DrawPlanet(X1, X2, X3, X4, Y1, Y2, ID);
				};

			}
			void PlanetP(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
			{
				if (menuLink.planets[3].Leader.mission == true && menuLink.Rick.artifact[3] == false)
				{
					int ID = 5;
					DrawPlanet(X1, X2, X3, X4, Y1, Y2, ID);
				};

			}
			void Waititi(string Name, int X1, int X2, int X3, int X4, int Y1, int Y2)
			{
				if (menuLink.planets[4].Leader.mission == true && menuLink.Rick.artifact[4] == false)
				{
					int ID = 5;
					DrawPlanet(X1, X2, X3, X4, Y1, Y2, ID);
				};

			}
		}

		public void DrawStatusBar(MenuLink menuLink)
		{

			HealthBar();
			ControlList();
			BottomOfMenu();


			void HealthBar()
			{
				// Initilize variables
				int realCurrentHealth = menuLink.spaceships[menuLink.currentShip].health; // <- Pull Variable from Ship Status
				int realTotalHealth = menuLink.spaceships[menuLink.currentShip].maxHealth;
				int statusCurrentHealth;
				int statusTotalHealth = 20;
				// Set Position
				CursorTo(2, 1);
				// Use proportion to calculate CurrentHealth for display
				statusCurrentHealth = (statusTotalHealth * realCurrentHealth) / realTotalHealth;
				// Expand string for display
				string displayHealth = new string(' ', statusCurrentHealth);
				// Displays Health status in Red
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Write($"{displayHealth}");
				// Caluclate Missing Health
				int statusMissingHealth = statusTotalHealth - statusCurrentHealth;
				string displayMissingHealth = new string(' ', statusMissingHealth);
				// Fills Missing Health in Gray
				Console.BackgroundColor = ConsoleColor.Gray;
				Console.Write($"{displayMissingHealth}");
				Console.ResetColor();
				// Display Health in Text
				CursorTo(2, 0);
				Console.Write($"Health : {realCurrentHealth} / {realTotalHealth}");
				CursorTo(2, 2);
				Console.WriteLine($"Money: {menuLink.Rick.money}\n  Current Ship: {menuLink.spaceships[menuLink.currentShip].shipName}");
			}
			void ControlList()
			{
				// Menu Divider
				Console.ForegroundColor = ConsoleColor.Cyan;
				CursorTo(30, 0);
				Console.Write("|");
				CursorTo(30, 1);
				Console.Write("|");
				CursorTo(30, 2);
				Console.Write("|");
				CursorTo(30, 3);
				Console.Write("|");
				CursorTo(95, 0);
				Console.Write("|");
				CursorTo(95, 1);
				Console.Write("|");
				CursorTo(95, 2);
				Console.Write("|");
				CursorTo(95, 3);
				Console.Write("|");
				Console.ResetColor();
				// Control List Title
				CursorTo(32, 0);
				Console.Write("Controls: ");
				//Control List
				CursorTo(45, 0);
				Console.Write("Arrow Keys: Move Target");
				CursorTo(45, 1);
				Console.Write("Enter : Action");
				CursorTo(45, 2);
				Console.Write("M : Menu");
				CursorTo(75, 0);
				Console.Write("Ctrl+C : Quit");
				CursorTo(75, 1);
				Console.Write("S : Save");
				CursorTo(75, 2);
				Console.Write("C : Credits");
			}
			void BottomOfMenu()
			{
				CursorTo(0, 4);
				Console.ForegroundColor = ConsoleColor.Cyan;
				string bar = new string('R', 140);
				Console.Write($"{bar}" + "iicckk!!!!");
				Console.ResetColor();
			}
		}
		

		public void CurrentPosition(int currentX, int currentY, int ship)
		{
			CursorTo(currentX, currentY);
			switch(ship)
			{
				case 0:
					Console.BackgroundColor = ConsoleColor.DarkGreen;
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("@");
					Console.ResetColor();
					break;
				case 1:
					Console.BackgroundColor = ConsoleColor.DarkMagenta;
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("#");
					Console.ResetColor();
					break;
				case 2:
					Console.BackgroundColor = ConsoleColor.DarkRed;
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("$");
					Console.ResetColor();
					break;
				default:
					break;
			}		
		}

		public void TargetPosition(int currentX, int currentY, int targetX, int targetY, int ship)
		{
			CursorTo(targetX, targetY);
			Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("O");
			Console.ResetColor();
		}
		
		
	
		public void DrawPlanet(int X1, int X2, int X3, int X4, int Y1, int Y2, int ID)
		{
			// Coord 1 //////////
			CursorTo(X1, Y1);
			Color(ID);
			ToConsole();
			// Coord 2 //////////
			CursorTo(X1, Y2);
			Color(ID);
			ToConsole();
			// Coord 3 //////////
			CursorTo(X2, Y1);
			Color(ID);
			ToConsole();
			// Coord 4 //////////
			CursorTo(X2, Y2);
			Color(ID);
			ToConsole();
			// Coord 5 //////////
			CursorTo(X3, Y1);
			Color(ID);
			ToConsole();
			// Coord 6 //////////
			CursorTo(X3, Y2);
			Color(ID);
			ToConsole();
			// Coord 7 //////////
			CursorTo(X4, Y1);
			Color(ID);
			ToConsole();
			// Coord 8 //////////
			CursorTo(X4, Y2);
			Color(ID);
			ToConsole();
		}

		public void Color(int ID)
		{
	
			switch (ID)
			{
				case 0:
					Console.BackgroundColor = ConsoleColor.Blue;
					break;
				case 1:
					Console.BackgroundColor = ConsoleColor.Green;
					break;
				case 2:
					Console.BackgroundColor = ConsoleColor.Magenta;
					break;
				case 3:
					Console.BackgroundColor = ConsoleColor.White;
					break;
				case 4:
					Console.BackgroundColor = ConsoleColor.DarkGreen;
					break;
				case 5:
					Console.BackgroundColor = ConsoleColor.DarkGray;
					break;
				default:
					break;
			}
				
		}



		public void ToConsole()
		{
			Console.Write(" ");
			Console.ResetColor();
		}

		public void CursorTo(int x, int y)
		{
			Console.SetCursorPosition(x, y);
		}

		// For Development
		public void StatusID(int statusID)
		{
			int statusx = Console.CursorLeft;
			int statusy = Console.CursorTop;
			Console.SetCursorPosition(2, 38);
			Console.Write($"StatusID: {statusID}");
			Console.SetCursorPosition(statusx, statusy);
			Console.Read();
		}
	}	
}
		

	
