using System;
using System.Linq;

namespace PeaceAmongWorlds
{
	public class Draw
	{


		public Draw()
		{
		}


		public void DrawPlanets()
		{
			(int[] xArrayEarth, int[] yArrayEarth, int IDEarth) = Planets.Earth();
			DrawToConsole(xArrayEarth, yArrayEarth, IDEarth);
			Planets Hoth = new Planets();
			(int[] xArrayHoth, int[] yArrayHoth, int IDHoth) = Hoth.Hoth();
			DrawToConsole(xArrayHoth, yArrayHoth, IDHoth);
			Planets LV426 = new Planets();
			LV426.LV426();

			Planets Naboo = new Planets();
			Naboo.Naboo();

			Planets Tatooine = new Planets();
			Tatooine.Tatooine();

			Planets DeathStar = new Planets();
			DeathStar.DeathStar();



		}

		public void DrawToConsole(int[] xArray, int[] yArray, int ID)
		{
			for (int x = 0; x < xArray.Length; x++)
			{
				for (int y = 0; y < yArray.Length; y++)
				{
					switch ((ID)
)
					{
						case 1:
							Console.BackgroundColor = ConsoleColor.Blue;
							continue;
						case 2:
							Console.BackgroundColor = ConsoleColor.Green;
							continue;
						default:
							break;
					}
					Console.Write(" ");
					Console.ResetColor();
					
				}
			}

		}

	}
}