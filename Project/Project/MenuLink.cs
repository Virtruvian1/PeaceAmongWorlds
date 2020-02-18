using System;

namespace Project
{
	public class MenuLink
	{
		public MenuLink()
		{
		}

		public void MenuLink()
        {
			var Movement = new Movement();
			var Draw = new Draw();
			if (Movement.currentX == Draw.Earth.X1 || 
				Movement.currentX == Draw.Earth.X2 || 
				Movement.currentX == Draw.Earth.X3 || 
				Movement.currentX == Draw.Earth.X4 &&
				Movement.currentY == Draw.Earth.Y1 ||
				Movement.currentY == Draw.Earth.Y2 )
            {
				Console.Write("Earth --------- Test ");
            }
        }



	}

}
