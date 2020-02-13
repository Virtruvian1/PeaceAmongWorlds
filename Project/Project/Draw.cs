using System;
using System.Linq;
using System.Collections.Generic;

namespace PeaceAmongWorlds
{
	// Version 1.0
	public class Draw
	{


		public Draw()
		{
		}

		public void DrawPlanets()
		{
			Console.Title = "PEACE AMOUNG WORLDS!!!";
			Console.SetWindowSize(150, 40);
			Earth();
			Hoth();
			LV426();
			Naboo();
			Tatooine();
			DeathStar();

			void Earth()
			{
				int ID = 1;
				var Planets = new Planets("Earth", 75, 76, 77, 78, 15, 16);
				DrawPlanet(Planets.X1, Planets.X2, Planets.X3, Planets.X4, Planets.Y1, Planets.Y2, ID);
			}
			void Hoth()
			{
				int ID = 2;
				var Planets = new Planets("Hoth", 27, 28, 29, 30, 9, 10);
				DrawPlanet(Planets.X1, Planets.X2, Planets.X3, Planets.X4, Planets.Y1, Planets.Y2, ID);
			}
			void LV426()
			{
				int ID = 3;
				var Planets = new Planets("LV426", 100, 101, 102, 103, 19, 20);
				DrawPlanet(Planets.X1, Planets.X2, Planets.X3, Planets.X4, Planets.Y1, Planets.Y2, ID);
			}
			void Naboo()
			{
				int ID = 4;
				var Planets = new Planets("Naboo", 25, 26, 27, 28, 23, 24);
				DrawPlanet(Planets.X1, Planets.X2, Planets.X3, Planets.X4, Planets.Y1, Planets.Y2, ID);
			}
			void Tatooine()
			{
				int ID = 5;
				var Planets = new Planets("Tatooine", 65, 66, 67, 68, 37, 38);
				DrawPlanet(Planets.X1, Planets.X2, Planets.X3, Planets.X4, Planets.Y1, Planets.Y2, ID);
			}
			void DeathStar()
			{
				int ID = 6;
				var Planets = new Planets("DeathStar", 130, 131, 132, 133, 5, 6);
				DrawPlanet(Planets.X1, Planets.X2, Planets.X3, Planets.X4, Planets.Y1, Planets.Y2, ID);
			}
		}

		public void DrawStatusBar()
		{
			HealthBar();
			ControlList();
			DisplayCurrentPostion();
			BottomOfMenu();

			void HealthBar()
			{
				int realCurrentHealth = 30; //Pull Variable from Ship Status
				int realTotalHealth = 100;
				int statusCurrentHealth;
				int statusTotalHealth = 20;
				Console.SetCursorPosition(2, 1);
				statusCurrentHealth = (statusTotalHealth * realCurrentHealth) / realTotalHealth;
				string displayHealth = new string(' ', statusCurrentHealth);
				Console.BackgroundColor = ConsoleColor.Red;
				Console.Write($"{displayHealth}");
				int statusMissingHealth = statusTotalHealth - statusCurrentHealth;
				string displayMissingHealth = new string(' ', statusMissingHealth);
				Console.BackgroundColor = ConsoleColor.Gray;
				Console.Write($"{displayMissingHealth}");
				Console.ResetColor();
				Console.SetCursorPosition(2, 0);
				Console.Write($"Health : {realCurrentHealth} / {realTotalHealth}");
			}

			void ControlList()
			{
				// Menu Divider
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.SetCursorPosition(30, 0);
				Console.Write("|");
				Console.SetCursorPosition(30, 1);
				Console.Write("|");
				Console.SetCursorPosition(30, 2);
				Console.Write("|");
				Console.SetCursorPosition(95, 0);
				Console.Write("|");
				Console.SetCursorPosition(95, 1);
				Console.Write("|");
				Console.SetCursorPosition(95, 2);
				Console.Write("|");
				Console.ResetColor();
				// Control List Title
				Console.SetCursorPosition(32, 0);
				Console.Write("Controls: ");
				// Control List
				Console.SetCursorPosition(45, 0);
				Console.Write("Arrow Keys: Move Target");
				Console.SetCursorPosition(45, 1);
				Console.Write("Enter : Action");
				Console.SetCursorPosition(45, 2);
				Console.Write("M : Menu");
				Console.SetCursorPosition(75, 0);
				Console.Write("Ctrl+C : Quit");
				Console.SetCursorPosition(75, 1);
				Console.Write("S : Save");
				Console.SetCursorPosition(75, 2);
				Console.Write("C : Credits");
			}

			void DisplayCurrentPostion()
			{
				Console.SetCursorPosition(97, 0);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("Current Postion ( X, Y )");
				Console.SetCursorPosition(97, 1);
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.Write("Target Postion  ( X, Y )");
				Console.ResetColor();
			}

			void BottomOfMenu()
			{
				Console.SetCursorPosition(0, 3);
				Console.ForegroundColor = ConsoleColor.Cyan;
				string bar = new string('R', 140);
				Console.Write($"{bar}" + "iicckk!!!!");
				Console.ResetColor();
			}
		}
		
	
		public void DrawPlanet(int X1, int X2, int X3, int X4, int Y1, int Y2, int ID)
		{
			Console.SetCursorPosition(X1, Y1);
			Color(ID);
			Console.SetCursorPosition(X1, Y2);
			Color(ID);
			Console.SetCursorPosition(X2, Y1);
			Color(ID);
			Console.SetCursorPosition(X2, Y2);
			Color(ID);
			Console.SetCursorPosition(X3, Y1);
			Color(ID);
			Console.SetCursorPosition(X3, Y2);
			Color(ID);
			Console.SetCursorPosition(X4, Y1);
			Color(ID);
			Console.SetCursorPosition(X4, Y2);
			Color(ID);
		}

		public void Color(int ID)
		{
			switch (ID)
			{
				case 1:
					Console.BackgroundColor = ConsoleColor.Blue;
					ToConsole();
					break;
				case 2:
					Console.BackgroundColor = ConsoleColor.Green;
					ToConsole();
					break;
				case 3:
					Console.BackgroundColor = ConsoleColor.Magenta;
					ToConsole();
					break;
				case 4:
					Console.BackgroundColor = ConsoleColor.White;
					ToConsole();
					break;
				case 5:
					Console.BackgroundColor = ConsoleColor.DarkGreen;
					ToConsole();
					break;
				case 6:
					Console.BackgroundColor = ConsoleColor.DarkGray;
					ToConsole();
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
	}	
}
		

	
