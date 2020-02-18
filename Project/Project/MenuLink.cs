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
			
			var Draw = new Draw();
			if (currentX == 75 || 
				currentX == 76 || 
				currentX == 77 || 
				currentX == 78 &&
				currentY == 15 ||
				currentY == 16 )
            {
				int ID = 0;
				Console.Clear();
				Program p = new Program();
				p.GameEngine();
			}
        }



	}

}
