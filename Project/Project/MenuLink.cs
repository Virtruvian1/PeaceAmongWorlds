using System;

namespace Project
{
	public class MenuLink
	{

		public MenuLink()
		{
		}

		public void MenuLinks(int currentX, int currentY)
        {
			
			if (( currentX == 75 || currentX == 76 || currentX == 77 || currentX == 78 ) && ( currentY == 15 || currentY == 16 ))
            {
				Engine(0);
			}

			if (( currentX == 27 || currentX == 28 || currentX == 29 || currentX == 30 ) && ( currentY == 9 || currentY == 10 ))
			{
				Engine(1);
			}

			if (( currentX == 100 || currentX == 101 || currentX == 102 || currentX == 103 ) && ( currentY == 19 || currentY == 20 ))
			{
				Engine(2);
			}

			if ((currentX == 25 || currentX == 26 || currentX == 27 || currentX == 28 ) && ( currentY == 23 || currentY == 24 ))
			{
				Engine(3);
			}

			if (( currentX == 65 || currentX == 66 || currentX == 67 || currentX == 68 ) && ( currentY == 37 || currentY == 38 ))
			{
				Engine(4);
			}

			if (( currentX == 130 || currentX == 131 || currentX == 132 || currentX == 133 ) && ( currentY == 5 || currentY == 6 ))
			{
				Engine(5);
			}
		}


		public void Engine(int ID)
		{
			Console.Clear();
			Program p = new Program();
			p.GameEngine();
		}
	}

}
